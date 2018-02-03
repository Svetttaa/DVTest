using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Model
{
	public class User
	{
		public Guid ID { get; set; } = Guid.NewGuid();
		[Required,Display(Name = "Электроная почта") ] public string Account { get; set; }

		//Нулевой пароль для новых пользователей, которые еще не изменили свой пароль
		[Required,Display(Name = "Пароль")]
		public string Password { get; set; } = "0";

		[Required, Display(Name = "ФИО")]
		public string Name { get; set; }

	}
}
