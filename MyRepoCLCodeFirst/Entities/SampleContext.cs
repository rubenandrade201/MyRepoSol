using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRepoCLCodeFirst.Entities
{
    public class SampleContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Course> Courses  { get; set; }

        //public SampleContext(DbContextOptions<SampleContext> options) : base(options)
        //{

        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conStr = "Data Source=DESKTOP-2GR0051;Initial Catalog=MyRepoCodeFirst;user id=sa;password=techno.2008*";
            optionsBuilder.UseSqlServer(conStr);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
