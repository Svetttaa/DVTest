using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Post.Model;

namespace Post.WinFormsClient
{
	class ServiceClient
	{

		private static HttpClient _client;

		public static void Initialize()
		{
			_client = new HttpClient
			{
				BaseAddress = new Uri(@"http://localhost:60000/api/")
			};
			_client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			_client.GetAsync(@"init");
		}

		#region Users

		public static object LoginUser(User user)
		{
			var pesponse = _client.PostAsJsonAsync(@"users/login", user).Result.Content;
			try
			{
				user = pesponse.ReadAsAsync<User>().Result;
				return user;
			}
			catch (UnsupportedMediaTypeException)
			{
				return pesponse.ReadAsStringAsync().Result;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return new User();
		}

		public static IEnumerable<User> GetAllUsers()
		{
			var response = _client.GetAsync(@"users/getAllUsers").Result;

			try
			{
				response.EnsureSuccessStatusCode();
				var ret = response.Content.ReadAsAsync<User[]>().Result;
				return ret;
			}
			catch (UnsupportedMediaTypeException)
			{
				MessageBox.Show(response.Content.ReadAsStringAsync().Result);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return null;
		}

		public static void ChangePassword(User user)
		{
			var response = _client.PostAsJsonAsync(@"users/changePassword/", user).Result;

			try
			{
				response.EnsureSuccessStatusCode();
			}
			catch (Exception e)
			{
				string s = response.Content.ReadAsStringAsync().Result;

				if (String.IsNullOrWhiteSpace(s))
					MessageBox.Show(e.Message);
				else
					MessageBox.Show(s);
			}
		}

		public static User GetUser(Guid userId)
		{
			var response = _client.GetAsync(@"users/getUser/" + userId).Result;

			try
			{
				response.EnsureSuccessStatusCode();

				var user = response.Content.ReadAsAsync<User>().Result;

				return user;
			}
			catch (UnsupportedMediaTypeException)
			{
				MessageBox.Show(response.Content.ReadAsStringAsync().Result);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return null;
		}

		public static IEnumerable<User> SearchUsers(string login)
		{
			var response = _client.GetAsync(@"users/" + login).Result;

			try
			{
				response.EnsureSuccessStatusCode();
				var ret = response.Content.ReadAsAsync<User[]>().Result;
				return ret;
			}
			catch (UnsupportedMediaTypeException)
			{
				MessageBox.Show(response.Content.ReadAsStringAsync().Result);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return null;
		}

		#endregion

		#region Letters

		public static IEnumerable<Letter> GetLetters(Guid userIdTo, int skip, int amount)
		{
			var response = _client.GetAsync($"letters/{userIdTo}/{skip}/{amount}").Result;

			try
			{
				//response.EnsureSuccessStatusCode();

				var ret = response.Content.ReadAsAsync<Model.Letter[]>().Result;

				return ret;
			}
			catch (UnsupportedMediaTypeException)
			{
				MessageBox.Show(response.Content.ReadAsStringAsync().Result);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return null;
		}

		public static Letter SendLetter(Letter letter)
		{
			var pesponse = _client.PostAsJsonAsync(@"letters/send", letter).Result.Content;

			try
			{
				var ret = pesponse.ReadAsAsync<Model.Letter>().Result;
				return ret;
			}
			catch (UnsupportedMediaTypeException)
			{
				MessageBox.Show(pesponse.ReadAsStringAsync().Result);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return null;
		}

		public static void DeleteLetter(Guid id)
		{
			var response = _client.DeleteAsync(@"letters/" + id).Result;

			try
			{
				response.EnsureSuccessStatusCode();
			}
			catch (Exception e)
			{
				string s = response.Content.ReadAsStringAsync().Result;

				if (String.IsNullOrWhiteSpace(s))
					MessageBox.Show(e.Message);
				else
					MessageBox.Show(s);
			}
		}

		public static Letter GetLetter(Guid id)
		{
			var response = _client.GetAsync(@"letters/getLetter/" + id).Result;

			try
			{
			//	response.EnsureSuccessStatusCode();
				var ret = response.Content.ReadAsAsync<Letter>().Result;

				return ret;
			}
			catch (UnsupportedMediaTypeException)
			{
				MessageBox.Show(response.Content.ReadAsStringAsync().Result);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return null;
		}

		public static void ChangeReadStatus(Guid id)
		{
			var response = _client.GetAsync("letters/readLetter/"+id).Result;

			try
			{
				response.EnsureSuccessStatusCode();
			}
			catch (Exception e)
			{
				string s = response.Content.ReadAsStringAsync().Result;

				if (String.IsNullOrWhiteSpace(s))
					MessageBox.Show(e.Message);
				else
					MessageBox.Show(s);
			}
		}

		public static int GetAmountLetters(Guid userFromId)
		{
			var response = _client.GetAsync(@"letters/getAmount/" + userFromId).Result;

			try
			{
				var ret = response.Content.ReadAsAsync<int>().Result;

				return ret;
			}
			catch (UnsupportedMediaTypeException)
			{
				MessageBox.Show(response.Content.ReadAsStringAsync().Result);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return 0;
		}


		#endregion

		public static byte[] GetBytes(string path)
		{
			return File.ReadAllBytes(path);
		}

		public static void WriteFile(string path, byte[] bytes)
		{
			using (Stream file = File.OpenWrite(path))
			{
				file.Write(bytes, 0, bytes.Length);
			}
		}
	}
}
