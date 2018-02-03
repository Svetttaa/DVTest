using System.ComponentModel.DataAnnotations;

namespace Post.WebAdmin.Models
{
	public class LoginModel
	{
		[Required]
		public  string Account { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}