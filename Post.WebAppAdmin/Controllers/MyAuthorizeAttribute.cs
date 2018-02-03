using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Post.WebAppAdmin.Controllers
{
	public class MyAuthorizeAttribute : AuthorizeAttribute
	{
		private string[] allowedUsers = new string[] { };

		public MyAuthorizeAttribute()
		{ }

		protected override bool AuthorizeCore(HttpContextBase httpContext)
		{
			if (!String.IsNullOrEmpty(base.Users))
			{
				allowedUsers = base.Users.Split(new char[] { ',' });
				for (int i = 0; i < allowedUsers.Length; i++)
				{
					allowedUsers[i] = allowedUsers[i].Trim();
				}
			}
			

			return httpContext.Request.IsAuthenticated &&
			       User(httpContext) ;
		}

		private bool User(HttpContextBase httpContext)
		{
			if (allowedUsers.Length > 0)
			{
				return allowedUsers.Contains(httpContext.User.Identity.Name);
			}
			return true;
		}

	}
}