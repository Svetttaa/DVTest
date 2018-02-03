using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
//using System.Web.http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.Services.Description;
using Microsoft.Ajax.Utilities;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Post.Model;
using Post.Api.Controllers;
using Post.WebAppAdmin.Models;
using Post.WebAppAdmin.Controllers;

namespace Post.WebAppAdmin.Controllers
{
	public class HomeController : Controller
	{
		private readonly DataBaseContext _db = new DataBaseContext();

		public ActionResult Index()
		{
			return (User.Identity.IsAuthenticated) ? (ActionResult)View("AccountsList", _db.Users.ToList()) : RedirectToAction("Login", "Home");
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		[Authorize(Users = "admin@mail.ru")]
		[HttpGet]
		public ActionResult AddUser(List<string> messages = null)
		{
			if (messages != null)
			{
				ViewBag.Errors = messages;
			}
			return View("AddUser");
		}

		[Authorize]
		[HttpGet]
		public ActionResult AccountsList()
		{
			return View("AccountsList", _db.Users.ToList());
		}

		[Authorize]
		[HttpGet]
		public ActionResult RemovePassword(Guid id)
		{
			(new AdminsController()).RemovePassword(id);
			return View("AccountsList", _db.Users.ToList());
		}

		[Authorize]
		[HttpPost]
		public ActionResult AddUser(User user)
		{
			user.Account += "@mail.ru";
			List<string> messages = new List<string>();
			int errors = 0;

			if (string.IsNullOrWhiteSpace(user.Account.Split('@')[0]))
			{
				messages.Add("Электронный адрес не должен быть пустым<br/>");
				errors++;
			}
			if (_db.Users.Any(x => x.Account == user.Account))
			{
				messages.Add("Электронный адрес должен быть уникальным<br/>");
				errors++;
			}
			if (_db.Users.Any(x => x.Name == user.Name))
			{
				messages.Add("ФИО должены быть уникальными<br/>");
				errors++;
			}
			if (string.IsNullOrWhiteSpace(user.Name))
			{
				messages.Add("ФИО не должно быть пустым");
				errors++;
			}

			if (errors > 0)
			{
				var values = new RouteValueDictionary(messages
													  .Select((item, index) => new { item, index })
													  .ToDictionary(
																	key => string.Format("[{0}]", key.index),
																	value => (object)value.item
																   )
													 );
				return RedirectToAction("AddUser", values);
			}
			else
			{
				(new AdminsController()).AddNewAccount(user);

				return RedirectToAction("AccountsList");
			}

		}

		[Authorize, HttpGet]
		public ActionResult DeleteUser(Guid id)
		{
			(new AdminsController()).DeleteUser(id);
			return View("AccountsList", _db.Users.ToList());
		}

		[Authorize]
		[HttpGet]
		public ActionResult EditData(Guid id)//, List<string> values)
		{
			//if (values != null)
			//{
			//	ViewBag.Messages = values;
			//}
			if (HttpContext.Session.Count > 0)
			{
				ViewBag.Messages = (List<string>)HttpContext.Session["messages"];
			}
			return View("EditData", _db.Users.First(x => x.ID == id));
		}

		[Authorize]
		[HttpPost]
		public ActionResult EditData(User user)
		{
			List<string> messages = new List<string>();
			int errors = 0;

			if (string.IsNullOrWhiteSpace(user.Account))
			{
				messages.Add("Электронный адрес не должен быть пустым<br/>");
				errors++;
			}
			if (_db.Users.Any(x => x.Account == user.Account))
			{
				messages.Add("Электронный адрес должен быть уникальным<br/>");
				errors++;
			}
			if (_db.Users.Any(x => x.Name == user.Name))
			{
				messages.Add("ФИО должены быть уникальными<br/>");
				errors++;
			}
			if (string.IsNullOrWhiteSpace(user.Name))
			{
				messages.Add("ФИО не должно быть пустым");
				errors++;
			}

			if (errors > 0)
			{
				//HttpContext.Items.Add("messages", messages);
				HttpContext.Session.Add("messages", messages);
				//ViewBag.Messages = messages;
				//var values = new RouteValueDictionary(messages
				//									  .Select((item, index) => new { item, index })
				//									  .ToDictionary(
				//													key => string.Format("[{0}]", key.index),
				//													value => (object)value.item
				//												   )
				//									 );
				//return RedirectToAction("EditData", new { user.ID, values });
				return RedirectToAction("EditData", new { user.ID });
			}

			else
			{
				new AdminsController().ChangeAccountName(user);

				return RedirectToAction("AccountsList", _db.Users.ToList());
			}
		}



		[AllowAnonymous]
		public ActionResult Login(List<string> messages = null)
		{
			if (messages != null)
			{
				ViewBag.Errors = messages;
			}

			return View("Login");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login(LoginModel model)
		{
			var messages = new List<string>();
			int errors = 0;
			if (ModelState.IsValid)
			{
				if (string.IsNullOrWhiteSpace(model.Account))
				{
					messages.Add("Эл.Почта не должна быть пустая");
					errors++;
				}

				if (string.IsNullOrWhiteSpace(model.Password))
				{
					messages.Add("Пароль не должен быть пустым");
					errors++;
				}
				User user;
				using (_db)
				{
					user = _db.Users.FirstOrDefault(u => u.Account == model.Account && u.Password == model.Password);

				}
				if (user != null && model.Account.Split('@')[0].ToLower() == "admin")
				{
					FormsAuthentication.SetAuthCookie(model.Account, true);
					return RedirectToAction("Index", "Home");
				}
				else
				{
					messages.Add("Введенные данные не являются верными для администратора");
					errors++;
				}

				if (errors > 0)
				{

					var values = new RouteValueDictionary(messages
															  .Select((item, index) => new { item, index })
															  .ToDictionary(
																			key => string.Format("[{0}]", key.index),
																			value => (object)value.item
																		   )
														 );
					return RedirectToAction("Login", values);
				}
			}

			return View(model);
		}

		[Authorize]
		public ActionResult Logoff()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Login", "Home");
		}

	}

}
