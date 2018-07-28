using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlogNew.Entity;

namespace MyBlogNew.Common
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MyBlogNewEntities : DbContext
    {
        public MyBlogNewEntities()
            //: base("myblognewEntities")
            : base("name=myblognewEntities")
        {
        }
        public DbSet<theme> Themes { get; set; }

        public DbSet<navigation> Navigations { get; set; }

        public DbSet<diary> Diaries { get; set; }

        public DbSet<read> Reads { get; set; }

        public DbSet<testTable> TestTables { get; set; }
    }
}