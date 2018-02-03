using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Post.Model
{
	public class User
	{
		public Guid ID { get; set; }
		[Required] public string Account { get; set; }
		[Required] public string Password { get; set; }
	}
}