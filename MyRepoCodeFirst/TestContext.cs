using Microsoft.EntityFrameworkCore;
using MyRepoCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRepoCodeFirst
{
    public class TestContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var conStr = @"Data Source=DESKTOP-2GR0051;Initial Catalog=MyRepoCodeFirst;user id=sa;password=techno.2008*";
            options.UseSqlServer(conStr);
        }
    }
}
