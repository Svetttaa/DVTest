using System.ComponentModel.DataAnnotations;

namespace Post.WebAppAdmin.Models
{
	public class LoginModel
	{
		[Required, Display(Name = "Эл. почта")]
		public string Account { get; set; }

		[Required,Display(Name = "Пароль")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}