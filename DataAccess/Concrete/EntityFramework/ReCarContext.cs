using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-3651C5JQ\SQLEXPRESS;Database=ReCar;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Brand> Brands { get; set; }
    }
}
