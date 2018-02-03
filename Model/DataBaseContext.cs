using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Post.Model
{
	public class DataBaseContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Letter> Letters { get; set; }

		public DataBaseContext() : base("name=DefaultConnection")
		{
			Configuration.LazyLoadingEnabled = false;
		}

		public class AppDbInitializer : DropCreateDatabaseAlways<DataBaseContext>
		{

		}
	} 
}
