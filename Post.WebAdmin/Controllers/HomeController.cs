using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
//using System.Web.Http;
using System.Web.Mvc;
using System.Web.Security;
using Post.Model;
using Post.Api.Controllers;
using Post.WebAdmin.Models;

namespace Post.WebAdmin.Controllers
{
	public class HomeController : Controller
	{
		private readonly DataBaseContext _db = new DataBaseContext();

		public ActionResult Index()
		{
			string result = "Вы не авторизованы";
			if (User.Identity.IsAuthenticated)
			{
				result = "Ваш логин: " + User.Identity.Name;
			}

			ViewBag.Message = result;
			return View("Index");
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
		[Authorize]
		[HttpGet]
		public ActionResult AddUser()
		{
			//_db.Users.Count();
			return (User.Identity.IsAuthenticated) ? View("AddUser") : View("Login");
		}
		[HttpGet]
		public ActionResult AccountsList()
		{
			return (User.Identity.IsAuthenticated) ? View("AccountsList",_db.Users.ToList()) : View("Login");
		}
		
		[HttpGet]
		public ActionResult RemovePassword(Guid id)
		{
			(new AdminsController()).RemovePassword(id);
			return View("AccountsList", _db.Users.ToList());
		}
		
		[HttpPost]
		public ActionResult AddUser(User user)
		{
			(new AdminsController()).AddNewAccount(user);
			
			return RedirectToAction("AccountsList");
		}
		
		[HttpGet]
		public ActionResult DeleteUser(Guid id)
		{
			(new AdminsController()).DeleteUser(id);
			return View("AccountsList", _db.Users.ToList());
		}
		[HttpGet]
		public ActionResult EditData(Guid id)
		{
			return View("EditData",_db.Users.First(x=>x.ID==id));
		}
		//исправить проблему с пробелами и сделать авторизацию
		[HttpPost]
		public ActionResult EditData(User user)
		{
			if(string.IsNullOrEmpty(user.Account)|| string.IsNullOrWhiteSpace(user.Account))
				user.Account = _db.Users.First(x => x.ID == user.ID).Account;

			if (string.IsNullOrEmpty(user.Name)|| string.IsNullOrWhiteSpace(user.Name))
				user.Account = _db.Users.First(x => x.ID == user.ID).Name;

			(new AdminsController()).ChangeAccountName(user);

			return RedirectToAction("AccountsList");
		}
		[AllowAnonymous]
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login(LoginModel model)
		{
			if (ModelState.IsValid)
			{
				// поиск пользователя в бд
				User user = null;
				using (DataBaseContext db = new DataBaseContext())
				{
					user = db.Users.FirstOrDefault(u => u.Account == model.Account && u.Password == model.Password);

				}
				if (user != null)
				{
					FormsAuthentication.SetAuthCookie(model.Account, true);
					return RedirectToAction("Index", "Home");
				}
				else
				{
					ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
				}
			}

			return View(model);
		}

		public ActionResult Logoff()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Index", "Home");
		}
		
	}
}
