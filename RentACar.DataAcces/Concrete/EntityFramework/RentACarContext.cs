using Microsoft.EntityFrameworkCore;
using RentACar.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Core.Entities.Concrete;

namespace RentACar.DataAcces.Concrete.EntityFramework
{
    public class RentACarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationsClaims { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
            Database=RentACar;Trusted_Connection=true");
        }
    }
}
