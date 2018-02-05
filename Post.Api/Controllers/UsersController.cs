using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NLog;
using Post.Model;

namespace Post.Api.Controllers
{
    public class UsersController : ApiController
    {
	    private readonly DataBaseContext _db = new DataBaseContext();
	    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
	    private readonly Stopwatch _timer = new Stopwatch();
		private const int MaxTime = 1000;
		/// <summary>
		/// Возвращает список всех сотрудников компании
		/// </summary>
		/// <returns> список объектов User в случае успеха</returns>
		[HttpGet, Route("api/users/getAllUsers")]
		public IEnumerable<User> GetAllUsers()
	    {
		    _logger.Info($"Получение списка сотрудников");

		    try
		    {
			    _timer.Restart();

			    var ret = _db.Users.ToArray();

			    _logger.Info($"Получение списка сотрудников - успешно за {_timer.ElapsedMilliseconds} мс");
			    if (_timer.ElapsedMilliseconds > MaxTime)
				    _logger.Warn($"Получение списка сотрудников заняло {_timer.ElapsedMilliseconds} мс");

			    return ret;
		    }
		    catch (HttpResponseException)
		    {
			    throw;
		    }
		    catch (Exception e)
		    {
			    _logger.Error($"Oшибка при получении списка сотрудников: {e.Message}");
			    throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
		    }
		    finally
		    {
			    _timer.Stop();
		    }
		}

		/// <summary>
		/// Вход в учетную запись
		/// </summary>
		/// <param name="user">учетная запись пользователя</param>
		/// <returns>Объект User в случае успеха</returns>
		[HttpPost, Route("api/users/login")]
	    public User Login([FromBody] User user)
	    {
		    var account = user.Account;
		    var password = user.Password;

		    _logger.Info($"Попытка входа аккаунта {account}");

		    try
		    {
			    _timer.Restart();

			    if (!_db.Users.Any(u => u.Account == account))
			    {
				    _logger.Error($"Попытка входа аккаунта {account}: аккаунт не найден. Создаем исключение.");
				    throw Helper.GenerateException("Login is invalid", HttpStatusCode.BadRequest);
			    }
			    User userFromDB = _db.Users.First(u => u.Account == account);

			    if (userFromDB.Password != password)
			    {
				    _logger.Error($"Попытка входа аккаунта {account}: пароль неверный. Создаем исключение.");
				    throw Helper.GenerateException("Password is invalid", HttpStatusCode.BadRequest);
			    }


			    _logger.Info($"Вход пользователя {userFromDB.ID} - успешно за {_timer.ElapsedMilliseconds} мс");
			    if (_timer.ElapsedMilliseconds > MaxTime)
				    _logger.Warn($"Вход пользователя {userFromDB.ID} занял {_timer.ElapsedMilliseconds} мс");

			    return userFromDB;
		    }
		    catch (HttpResponseException)
		    {
			    throw;
		    }
		    catch (Exception e)
		    {
			    _logger.Error($"Ошибка при Попытке входа аккаунта {account}: {e.Message}");
			    throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
		    }
		    finally
		    {
			    _timer.Stop();
		    }
		}

		/// <summary>
		/// Изменение пароля учетной записи
		/// </summary>
		/// <param name="user">Учетная запись с новым паролем</param>
	    [HttpPost, Route("api/users/changePassword")]
	    public void ChangePassword([FromBody] User user)
	    {
		    _logger.Info($"Изменение пароля пользователя {user.ID}");

		    try
		    {
			    _timer.Restart();

			    Helper.CheckUser(user.ID);
			    if (!user.Password.Any())
			    {
				    _logger.Error($"Изменение пароля пользователя {user.ID}: новый пароль пустой. Создаем исключение.");
				    throw Helper.GenerateException("Password can't be empty", HttpStatusCode.BadRequest);
			    }
			    _db.Users.First(u => u.ID == user.ID).Password = user.Password;
			    _db.SaveChanges();

			    _logger.Info($"Изменение пароля пользователя {user.ID} - успешно за {_timer.ElapsedMilliseconds} мс");
			    if (_timer.ElapsedMilliseconds > MaxTime)
				    _logger.Warn($"Изменение пароля пользователя {user.ID} заняло {_timer.ElapsedMilliseconds} мс");
		    }
		    catch (HttpResponseException)
		    {
			    throw;
		    }
		    catch (Exception e)
		    {
			    _logger.Error($"Ошибка при изменении пароля пользователя {user.ID}: {e.Message}");
			    throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
		    }
		    finally
		    {
			    _timer.Stop();
		    }
		}

		/// <summary>
		/// Возвращает информацию о пользователе
		/// </summary>
		/// <param name="userId">ID пользователя</param>
		/// <returns>Объект User в случае успеха</returns>
		[HttpGet, Route("api/users/getUser/{userId}")]
		public User GetUser(Guid userId)
	    {
		    _logger.Info($"Получение информации о пользователе {userId}");

		    try
		    {
			    _timer.Restart();

			    Helper.CheckUser(userId);
			    var ret = _db.Users.First(u => u.ID == userId);

			    _logger.Info($"Получение информации о пользователе {userId} - успешно за {_timer.ElapsedMilliseconds} мс");
			    if (_timer.ElapsedMilliseconds > MaxTime)
				    _logger.Warn($"Получение информации о пользователе {userId} заняло {_timer.ElapsedMilliseconds} мс");

			    return ret;
		    }
		    catch (HttpResponseException)
		    {
			    throw;
		    }
		    catch (Exception e)
		    {
			    _logger.Error($"Oшибка при получении информации о пользователе {userId}: {e.Message}");
			    throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
		    }
		    finally
		    {
			    _timer.Stop();
		    }
	    }

	    /// <summary>
	    /// Возвращает массив пользователей с указанным логином( имя до @)
	    /// </summary>
	    /// <param name="login">Логин, по которому идет поиск</param>
	    /// <returns>Массив пользователей</returns>
		[HttpGet, Route("api/users/{login}")]
	    public IEnumerable<User> Search(string login)
	    {
		    _logger.Info($"Поиск пользователей по логину {login}");

		    try
		    {
			    _timer.Restart();

			    if (!login.Any())
			    {
				    _logger.Error("Поиск: пустой логин. Создаем исключение.");
				    throw Helper.GenerateException("Login can't be empty", HttpStatusCode.BadRequest);
			    }
			    var ret = _db.Users.Where(u => u.Account.Contains(login)).ToArray();

			    _timer.Stop();
			    _logger.Info($"Поиск пользователей по логину {login} - успешно за {_timer.ElapsedMilliseconds} мс");
			    if (_timer.ElapsedMilliseconds > MaxTime)
				    _logger.Warn($"Поиск пользователей по логину {login} заняла {_timer.ElapsedMilliseconds} мс");

			    return ret;
		    }
		    catch (HttpResponseException)
		    {
			    throw;
		    }
		    catch (Exception e)
		    {
			    _logger.Error($"Ошибка при поиске пользователей по логину {login}: {e.Message}");
			    throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
		    }
		    finally
		    {
			    _timer.Stop();
		    }
		}

		[HttpGet, Route("api/init")]
	    public void Initialize()
		    => Helper.Initialize();

	    [HttpGet, Route("api/clear")]
	    public void Clear()
		    => Helper.ClearDatabase();

	}
}
