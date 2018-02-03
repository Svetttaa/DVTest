using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Post.Model;

namespace Post.DBInitializer
{
	internal static class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("Установка инициализатора. ");
			Database.SetInitializer(new DataBaseContext.AppDbInitializer());
			Console.WriteLine("Успешно.");

			try
			{
				Console.Write("Получение контекста БД. ");
				var db = new DataBaseContext();
				Console.WriteLine("Успешно. ");

				Console.Write("Добавление данных. ");
				User One = new User()
				{
					ID = Guid.NewGuid(),
					Account = "account@mai.ru",
					Password = "Default",
					Name = "newName"
				};
				db.Users.Add(One);
				db.SaveChanges();
				Console.WriteLine(!db.Users.Any() ? "Неудача." : "Успешно.");
				Console.WriteLine("{0},{1},{2}",One.ID,One.Account,One.Password);
			}
			catch (Exception e)
			{
				Console.WriteLine("Неудача. \r\nОшибка: " + e.Message);
			}
			Console.Write("Любая клавиша для выхода...");
			Console.ReadKey();
		}
	}
}
