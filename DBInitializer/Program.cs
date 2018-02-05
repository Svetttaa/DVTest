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
				Console.WriteLine("Успешно. " + db.Letters.Count());

				Console.Write("Добавление данных. ");
				User one = new User()
				{
					ID = Guid.NewGuid(),
					Account = "admin@mail.ru",
					Password = "admin",
					Name = "Admin"
				};
				db.Users.Add(one);

				User two = new User()
				{
					ID = Guid.NewGuid(),
					Account = "sveta@mail.ru",
					Password = "1",
					Name = "Sveta"
				};
				db.Users.Add(two);
				//for (int i = 0; i < 30; i++)
				//{
				//	var letter = new Letter
				//	{
				//		ID = Guid.NewGuid(),
				//		UserFromID = Guid.Parse("8c855772-1745-4a2d-8701-99c0a5868a83"),
				//		UserToID = Guid.Parse("f96aeccd-9465-483f-b94d-a2b7becf7e66"),
				//		Title = "Letter from 8c85 N" + i,
				//		Text = "Товарищи! начало повседневной работы по формированию позиции позволяет выполнять важные задания по разработке новых предложений. Таким образом укрепление и развитие структуры играет важную роль в формировании систем массового участия. Идейные соображения высшего порядка, а также консультация с широким активом требуют от нас анализа систем массового участия. Идейные соображения высшего порядка, а также дальнейшее развитие различных форм деятельности позволяет оценить значение форм развития."
				//	};


				//	db.Letters.Add(letter);
				//}

				//for (int i = 0; i < 30; i++)
				//{
				//	var letter = new Letter
				//	{
				//		ID = Guid.NewGuid(),
				//		UserFromID = Guid.Parse("f96aeccd-9465-483f-b94d-a2b7becf7e66"),
				//		UserToID = Guid.Parse("8c855772-1745-4a2d-8701-99c0a5868a83"),
				//		Title = "Letter from f96a N" + i,
				//		Text = "Some text here"
				//	};


				//	db.Letters.Add(letter);
				//}

				db.SaveChanges();
				Console.WriteLine(!db.Users.Any() ? "Неудача." : "Успешно.");
				Console.WriteLine("Все :)");
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
