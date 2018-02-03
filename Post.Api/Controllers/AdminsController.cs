using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NLog;
using Post.Model;
using System.Data.Entity;

namespace Post.Api.Controllers
{

	public class AdminsController : ApiController
    {
	    private readonly DataBaseContext _db = new DataBaseContext();
	    private  readonly Logger _logger = LogManager.GetCurrentClassLogger();
	    private readonly Stopwatch _timer = new Stopwatch();
	    private const int MaxTime = 1000;

		/// <summary>
		/// Меняет имя аккаунта пользователя
		/// </summary>
		/// <param name="user">пользователь </param>
	    [HttpPost, Route("api/admin/changeAccountName")]
		public void ChangeAccountName([FromBody]User user)
	    {
		    _logger.Info($"Изменение имени аккаунта пользователя {user.ID}, новое имя аккаунта: {user.Account}, новое имя пользователя {user.Name}");

		    try
		    {
			    _timer.Restart();
			    Helper.CheckUser(user.ID);
			    if (!user.Account.Any())
			    {
				    _logger.Error($"Изменение имени аккаунта пользователя {user.ID}: новое имя аккаунта пусто. Создаем исключение.");
				    throw Helper.GenerateException("Nickname can't be empty", HttpStatusCode.BadRequest);
			    }
			    if (!user.Name.Any())
			    {
				    _logger.Error($"Изменение имени аккаунта пользователя {user.ID}: новое имя пусто. Создаем исключение.");
				    throw Helper.GenerateException("Nickname can't be empty", HttpStatusCode.BadRequest);
			    }
				_db.Users.First(x => x.ID == user.ID).Account= user.Account;
			    _db.Users.First(x => x.ID == user.ID).Name = user.Name;
				_db.SaveChanges();

			    _logger.Info($"Изменение имени аккаунта пользователя {user.ID}, при новом имени аккаунта {user.Account} и новом имени пользователя {user.Name}- успешно за {_timer.ElapsedMilliseconds} мс");
			    if (_timer.ElapsedMilliseconds > MaxTime)
				    _logger.Warn($"Изменение имени аккаунта пользователя {user.ID}, при новом имени аккаунта {user.Account} и новом имени пользователя {user.Name} заняло {_timer.ElapsedMilliseconds} мс");
		    }
			catch (HttpResponseException)
		    {
			    throw;
		    }
		    catch (Exception e)
		    {
			    _logger.Error($"Ошибка при изменении имени аккаунта пользователя {user.ID}, имя аккаунта: {user.Account}, новое имя пользователя {user.Name}: {e.Message}");
			    throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
		    }
		    finally
		    {
			    _timer.Stop();
		    }

		}

		/// <summary>
		/// Добавление нового пользователя
		/// </summary>
		/// <param name="user"> Данные ФИО и имя аккаунта</param>
		/// <returns>Объект типа User в случае успеха</returns>
	    [HttpPost, Route("api/admin/addNewAccount")]
		public User AddNewAccount([FromBody]User user)
		{
			_logger.Info($"Добавление нового аккауента {user.Account}, ФИО: {user.Name}");

		    try
		    {
			    _timer.Restart();

			    if (!user.Account.Any()||!user.Name.Any())
			    {
				    _logger.Error($"Добавление нового аккауента {user.Account}, ФИО {user.Name}: новое имя аккаунта или ФИО пусто. Создаем исключение.");
				    throw Helper.GenerateException("Nickname can't be empty", HttpStatusCode.BadRequest);
			    }

			    var newUser = _db.Users.Add(user);
			    _db.SaveChanges();

			    _logger.Info($"Добавление нового аккауента {user.Account}, ФИО: {user.Name} - успешно за {_timer.ElapsedMilliseconds} мс");
			    if (_timer.ElapsedMilliseconds > MaxTime)
				    _logger.Warn($"Добавление нового аккауента {user.Account}, ФИО: {user.Name} заняло {_timer.ElapsedMilliseconds} мс");

			    return newUser;
		    }
			catch (HttpResponseException)
		    {
			    throw;
		    }
		    catch (Exception e)
		    {
			    _logger.Error($"Ошибка при добавлении нового аккауента {user.Account}, ФИО: {user.Name}: {e.Message}");
			    throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
		    }
		    finally
		    {
			    _timer.Stop();
		    }

		}

		/// <summary>
		/// Удаление пароля пользователя
		/// </summary>
		/// <param name="id">ID пользователя</param>
	    [HttpGet,Route("api/admin/removePassword/{id}")]
	    public void RemovePassword(Guid id)
	    {
		    _logger.Info($"Удаление пароля пользователя {id}");

		    try
		    {
			    _timer.Restart();
               Helper.CheckUser(id);

			    _db.Users.First(x=>x.ID==id).Password=Helper.NullPassword;
			    _db.SaveChanges();

			    _logger.Info($"Удаление пароля пользователя {id} - успешно за {_timer.ElapsedMilliseconds} мс");
			    if (_timer.ElapsedMilliseconds > MaxTime)
				    _logger.Warn($"Удаление пароля пользователя {id} заняло {_timer.ElapsedMilliseconds} мс");

		    }
		    catch (HttpResponseException)
		    {
			    throw;
		    }
		    catch (Exception e)
		    {
			    _logger.Error($"Ошибка при удалении пароля пользователя {id}: {e.Message}");
			    throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
		    }
		    finally
		    {
			    _timer.Stop();
		    }
		}

		/// <summary>
		/// Удаление пользователя
		/// </summary>
		/// <param name="id">ID пользователя</param>
	    [HttpDelete, Route("api/admin/{id}")]
	    public void DeleteUser(Guid id)
	    {
		    _logger.Info($"Удаление пользователя {id}");

		    try
		    {
			    _timer.Restart();
				Helper.CheckUser(id);
			    _db.Users.Remove(_db.Users.First(u => u.ID == id));
			    _db.SaveChanges();

			    _logger.Info($"Удаление пользователя {id} - успешно за {_timer.ElapsedMilliseconds} мс");
			    if (_timer.ElapsedMilliseconds > MaxTime)
				    _logger.Warn($"Удаление пользователя {id} заняло {_timer.ElapsedMilliseconds} мс");
		    }
		    catch (HttpResponseException)
		    {
			    throw;
		    }
		    catch (Exception e)
		    {
			    _logger.Error(e, $"Ошибка при удалении пользователя {id}");
			    throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
		    }
		    finally
		    {
			    _timer.Stop();
		    }
		}
	}
}
