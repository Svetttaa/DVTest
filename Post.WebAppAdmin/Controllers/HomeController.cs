using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Post.Model;
using Post.Api.Controllers;
using Post.WebAppAdmin.Models;
using System.ComponentModel.DataAnnotations;

namespace Post.WebAppAdmin.Controllers
{
	public class HomeController : Controller
	{
		private readonly DataBaseContext _db = new DataBaseContext();

		public ActionResult Index()
		{
			return RedirectToAction(User.Identity.IsAuthenticated ? "AccountsList" : "Login");
		}

		[Authorize, HttpGet]
		public ActionResult AddUser()
		{
			return View("AddUser");
		}

		[Authorize, HttpPost]
		public ActionResult AddUser(User user)
		{
			user.Account += "@mail.ru";
			user.Account = user.Account.ToLower();
			var messages = new List<Messages.MessagesEnum>();
			int errors = 0;

			if (string.IsNullOrWhiteSpace(user.Account.Split('@')[0]))
			{
				messages.Add(Messages.MessagesEnum.EmptyEmail);
				errors++;
			}
			if (_db.Users.Any(x => x.Account == user.Account))
			{
				messages.Add(Messages.MessagesEnum.UniqueEmail);
				errors++;
			}
			if (string.IsNullOrWhiteSpace(user.Name))
			{
				messages.Add(Messages.MessagesEnum.EmptyName);
				errors++;
			}

			if (errors > 0)
			{
				ViewBag.Errors = messages;
				return View("AddUser");
			}
			else
			{
				(new AdminsController()).AddNewAccount(user);
				return RedirectToAction("AccountsList");
			}

		}

		[Authorize, HttpGet]
		public ActionResult AccountsList()
		{
			return View("AccountsList", _db.Users.ToList());
		}

		[Authorize, HttpGet]
		public ActionResult RemovePassword(Guid id)
		{
			(new AdminsController()).RemovePassword(id);
			return View("AccountsList", _db.Users.ToList());
		}

		[Authorize, HttpGet]
		public ActionResult DeleteUser(Guid id)
		{
			(new AdminsController()).DeleteUser(id);
			return View("AccountsList", _db.Users.ToList());
		}

		[Authorize, HttpGet]
		public ActionResult EditData(Guid id)
		{
			return View("EditData", _db.Users.First(x => x.ID == id));
		}

		[Authorize, HttpPost]
		public ActionResult EditData(User user)
		{
			user.Account = user.Account.ToLower();
			var messages = new List<Messages.MessagesEnum>();
			int errors = 0;

			if (string.IsNullOrWhiteSpace(user.Account))
			{
				messages.Add(Messages.MessagesEnum.EmptyEmail);
				errors++;
			}
			if (_db.Users.Any(x => x.Account == user.Account && x.ID != user.ID))
			{
				messages.Add(Messages.MessagesEnum.UniqueEmail);
				errors++;
			}
			if (string.IsNullOrWhiteSpace(user.Name))
			{
				messages.Add(Messages.MessagesEnum.EmptyName);
				errors++;
			}

			if (errors > 0)
			{
				ViewBag.Errors = messages;
				return View("EditData");
			}
			else
			{
				new AdminsController().ChangeAccountName(user);
				return RedirectToAction("AccountsList", _db.Users.ToList());
			}
		}

		[AllowAnonymous]
		public ActionResult Login()
		{
			return View("Login");
		}

		[HttpPost, ValidateAntiForgeryToken]
		public ActionResult Login(LoginModel model)
		{
			var messages = new List<Messages.MessagesEnum>();
			int errors = 0;

			if (ModelState.IsValid)
			{
				if (string.IsNullOrWhiteSpace(model.Account))
				{
					messages.Add(Messages.MessagesEnum.EmptyEmail);
					errors++;
				}

				if (string.IsNullOrWhiteSpace(model.Password))
				{
					messages.Add(Messages.MessagesEnum.EmptyPassword);
					errors++;
				}

				// Тут проверяем на null
				if (errors > 0)
				{
					ViewBag.Errors = messages;
					return View("Login");
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
					messages.Add(Messages.MessagesEnum.NoRights);
					errors++;
				}

				// Тут проверяем права
				if (errors > 0)
				{
					ViewBag.Errors = messages;
					return View("Login");
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
