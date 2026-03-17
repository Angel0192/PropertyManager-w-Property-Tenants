using System.Net.Sockets;
using Microsoft.EntityFrameworkCore; 
using PropertyManager.Models;

namespace PropertyManager.Models
{
    public class ApplicationDbContext :  DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Property> Properties{get; set;}

        public DbSet<Tenant> Tenants{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Property table data
            modelBuilder.Entity<Property>().HasData(
                new Property
                {
                    PropertyID = 1,
                    PropertyName = "University Village",
                    Address = "123 Eagle Ln",
                    UnitNum = "1A",
                    MonthlyRent = 12000.00m
                },

                new Property
                {
                    PropertyID = 2,
                    PropertyName = "Suburban Heights",
                    Address = "456 West Side Dr",
                    UnitNum = "2B",
                    MonthlyRent = 950.00m
                },

                new Property
                {
                    PropertyID = 3,
                    PropertyName = "Archies House",
                    Address = "910 University Dr",
                    UnitNum = "N/A",
                    MonthlyRent = 0.00m
                },

                new Property
                {
                    PropertyID = 4,
                    PropertyName = "House",
                    Address = "915 University Dr",
                    UnitNum = "9C",
                    MonthlyRent = 67.00m
                }
            );

            // Tenants table data

            modelBuilder.Entity<Tenant>().HasData(
                new Tenant
                {
                    TenantID = 1,
                    FirstName = "Archie",
                    LastName = "BaldEage",
                    Email = "archieeagle@usi.edu",
                    PhoneNum = "123-456-7890",
                    PropertyID = 2,
                },

                new Tenant
                {
                    TenantID = 2,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "johndoe@hotmail.com",
                    PhoneNum = "098-765-4321",
                    PropertyID = 1,
                },

                new Tenant
                {
                    TenantID = 3,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Email = "janedoe@gmail.com",
                    PhoneNum = "234-567-1092",
                    PropertyID = 4
                }
            );


        }
    }
}