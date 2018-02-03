using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Post.Model
{
	public class DataBaseContext:DbContext
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