﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web.Http;
using NLog;
using Post.Model;

namespace Post.Api.Controllers
{
	public class LettersController : ApiController
	{
		private readonly DataBaseContext _db = new DataBaseContext();
		private readonly Logger _logger = LogManager.GetCurrentClassLogger();
		private readonly Stopwatch _timer = new Stopwatch();
		private const int MaxTime = 1000;

		/// <summary>
		/// Отправление письма
		/// </summary>
		/// <param name="letter"> Отправляемое письмо</param>
		/// <returns></returns>
		[HttpPost, Route("api/letters/send")]
		public Letter SendLetter([FromBody] Letter letter)
		{
			_logger.Info($"Отправление письма пользователю с id {letter.UserToID} от пользователя {letter.UserFromID}");

			try
			{
				_timer.Restart();

				var newLetter = _db.Letters.Add(letter);

				foreach (var attach in letter.Attaches)
				{
					_db.Attaches.Add(new Attach
					{
						AttachBytes = attach.AttachBytes,
						AttachName = attach.AttachName,
						ID = Guid.NewGuid(),
						LetterID = newLetter.ID
					});
				}

				_db.SaveChanges();

				_logger.Info($"Отправление сообщения - успешно за {_timer.ElapsedMilliseconds} мс");
				if (_timer.ElapsedMilliseconds > MaxTime)
					_logger.Warn($"Отправление сообщения заняло {_timer.ElapsedMilliseconds} мс");

				return newLetter;
			}
			catch (HttpResponseException)
			{
				throw;
			}
			catch (Exception e)
			{
				_logger.Error(e, $"Ошибка при отправлении письма пользователю с id {letter.UserToID} от пользователя {letter.UserFromID}");
				throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
			}
			finally
			{
				_timer.Stop();
			}
		}

		/// <summary>
		/// Удаляет письмо с указанным ID
		/// </summary>
		/// <param name="id">ID письма</param>
		[HttpDelete, Route("api/letters/{id}")]
		public void DeleteLetter(Guid id)
		{
			_logger.Info($"Удаление письма {id}");

			try
			{
				_timer.Restart();
				Helper.CheckLetter(id);
				_db.Letters.Remove(_db.Letters.First(m => m.ID == id));
				_db.SaveChanges();

				_logger.Info($"Удаление письма {id} - успешно за {_timer.ElapsedMilliseconds} мс");
				if (_timer.ElapsedMilliseconds > MaxTime)
					_logger.Warn($"Удаление письма {id} заняло {_timer.ElapsedMilliseconds} мс");
			}
			catch (HttpResponseException)
			{
				throw;
			}
			catch (Exception e)
			{
				_logger.Error(e, $"Ошибка при удалении письма {id}");
				throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
			}
			finally
			{
				_timer.Stop();
			}
		}

		/// <summary>
		/// Возвращает указанное количество писем
		/// </summary>
		/// <param name="userIdFrom">ID сотрудника-отправителя</param>
		/// <param name="userIdTo">ID сотрудника-получателя</param>
		/// <param name="skip">Количество пропускаемых писем</param>
		/// <param name="amount">Количество возвращаемых писем</param>
		/// <returns>Массив с письмами в случае успеха</returns>
		[HttpGet, Route("api/letters/{userIdTo}/{skip}/{amount}")]
		public IEnumerable<Letter> GetLetters(Guid userIdTo, int skip, int amount)
		{
			_logger.Info($"Получение писем пользователем с id {userIdTo} в количестве {amount} с пропуском {skip}");

			try
			{
				_timer.Restart();

				if (amount <= 0)
				{
					_logger.Info($"Получение писем пользователем с id {userIdTo} : ноль писем запрошено. Создаем исключение.");
					throw Helper.GenerateException("Can't get zero messages", HttpStatusCode.BadRequest);
				}

				var ret = _db.Letters.Any(l => l.UserToID == userIdTo)
							  ?
							  _db.Letters
								 .Include(l => l.UserFrom)
								 .Where(l => l.UserToID == userIdTo)
								 .OrderByDescending(l => l.Time)
								 .Skip(skip)
								 .Take(amount)
								 .ToArray()
							  :
							  new Letter[0];

				//var enumerable = ret;
				foreach (var r in ret)
				{
					if (string.IsNullOrWhiteSpace(r.Text)) continue;

					r.Text = (r.Text.Length > 15) ? r.Text.Substring(0, 15) : r.Text;
					r.Title = (r.Title.Length > 15) ? r.Title.Substring(0, 15) : r.Title;
				}
				_logger.Info($"Получение писем пользователем с id {userIdTo} в количестве {amount} с пропуском {skip} - успешно за {_timer.ElapsedMilliseconds} мс");
				if (_timer.ElapsedMilliseconds > MaxTime)
					_logger.Warn($"Получение писем пользователем с id {userIdTo} в количестве {amount} с пропуском {skip} заняло {_timer.ElapsedMilliseconds} мс");

				return ret;
			}
			catch (HttpResponseException)
			{
				throw;
			}
			catch (Exception e)
			{
				_logger.Error(e, $"Ошибка при получении писем пользователем с id {userIdTo}");
				throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
			}
			finally
			{
				_timer.Stop();
			}
		}

		/// <summary>
		/// Возвращает письмо
		/// </summary>
		/// <param name="id">ID письма</param>
		/// <returns>Объект Letter в случае успеха</returns>
		[HttpGet, Route("api/letters/getLetter/{id}")]
		public Letter GetLetter(Guid id)
		{
			_logger.Info($"Получение письма {id}");

			try
			{
				_timer.Restart();
				Helper.CheckLetter(id);
				 var ret = _db.Letters
							 .Include(x => x.UserFrom)
							 .First(l => l.ID == id);

				//ret.Attaches = new List<Attach>();
				//if (_db.Attaches.Any(x => x.LetterID == ret.ID))
				//	ret.Attaches = _db.Attaches.Where(x => x.LetterID == ret.ID).ToArray();

				_logger.Info($"Получение письма {id} - успешно за {_timer.ElapsedMilliseconds} мс");
				if (_timer.ElapsedMilliseconds > MaxTime)
					_logger.Warn($"Получение письма {id} заняло {_timer.ElapsedMilliseconds} мс");

				return ret;
			}
			catch (HttpResponseException)
			{
				throw;
			}
			catch (Exception e)
			{
				_logger.Error(e, $"Ошибка при получении письма {id}");
				throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
			}
			finally
			{
				_timer.Stop();
			}
		}

		[HttpGet, Route("api/letters/readLetter/{id}")]
		public void ChangeReadStatus(Guid id)
		{
			try
			{
				_db.Letters.First(x => x.ID == id).Read = true;
				_db.SaveChanges();
			}
			catch (Exception e)
			{
				_logger.Error(e, $"Ошибка при изменении статуса письма {id}");
				throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
			}
		}

		[HttpGet, Route("api/letters/getAmount/{userIdTo}")]
		public int GetAmountOfLetters(Guid userIdTo)
		{
			try
			{
				Helper.CheckUser(userIdTo);
				return _db.Letters.Count(x => x.UserToID == userIdTo);

			}
			catch (Exception e)
			{
				_logger.Error(e, $"При получении количества писем пользователю {userIdTo} произошла ошибка");
				throw Helper.GenerateException(e.Message, HttpStatusCode.InternalServerError);
			}
		}
	}
}
