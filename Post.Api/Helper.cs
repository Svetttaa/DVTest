using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using NLog;
using Post.Model;
using System.Net.Http;
using System.Web.Http;

namespace Post.Api
{
	public class Helper
	{
		private static readonly DataBaseContext Db = new DataBaseContext();
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		public readonly static string NullPassword = "0";

		public static void Initialize()
		{
			Db.Users.Any();
		}

		public static void ClearDatabase()
		{
			Db.Letters.RemoveRange(Db.Letters);
			Db.SaveChanges();
			//Database.SetInitializer(new AppDbInitializer());
		}

		public static void CheckUser(Guid id)
		{
			if (!Db.Users.Any(u => u.ID == id))
			{
				Logger.Error($"User ID is invalid: {id}");
				throw GenerateException("User ID is invalid", HttpStatusCode.BadRequest);
			}
		}

		public static void CheckLetter(Guid id)
		{
			if (!Db.Letters.Any(l => l.ID == id))
			{
				Logger.Error($"Letter ID is invalid: {id}");
				throw GenerateException("Letter ID is invalid", HttpStatusCode.BadRequest);
			}
		}

		public static Exception GenerateException(string message, HttpStatusCode code)
		{
			var ex = new HttpResponseMessage(code)
			{
				Content = new StringContent(message)
			};

			return new HttpResponseException(ex);
		}
	}
}