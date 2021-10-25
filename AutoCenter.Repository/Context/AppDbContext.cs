using AutoCenter.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository.Context
{
   public class AppDbContext : DbContext
   {
      public AppDbContext() : base()
      {

      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         var car = modelBuilder.Entity<Car>();
         car.HasKey(c => c.ID);

         car.Property(c => c.Brand).IsRequired().HasMaxLength(30);
         car.Property(c => c.Model).IsRequired().HasMaxLength(20);
         car.Property(c => c.Color).IsRequired().HasMaxLength(20);
         car.Property(c => c.PlateNumbers).IsRequired().HasMaxLength(15);
         car.Property(c => c.RentalPrice).IsRequired();

         var carType = modelBuilder.Entity<CarType>();
         carType.HasKey(ct => ct.ID);
         carType.HasAlternateKey(ct => ct.Name);
         carType.Property(ct => ct.Name).IsRequired().HasMaxLength(20);

         var customer = modelBuilder.Entity<Customer>();
         customer.HasKey(c => c.ID);
         customer.Property(c => c.Firstname).IsRequired().HasMaxLength(30);
         customer.Property(c => c.Lastname).IsRequired().HasMaxLength(30);
         customer.Property(c => c.Address).IsRequired().HasMaxLength(50);
         customer.Property(c => c.Phone).IsRequired().HasMaxLength(20);

         var order = modelBuilder.Entity<Order>();
         order.HasKey(o => o.ID);
         order.Property(o => o.OrderDate).IsRequired();

         var employee = modelBuilder.Entity<Employee>();

         employee.Property(e => e.Address).IsRequired().HasMaxLength(100);
         employee.Property(e => e.FirstName).IsRequired().HasMaxLength(30);
         employee.Property(e => e.LastName).IsRequired().HasMaxLength(50);
         employee.Property(e => e.IsDeleted).IsRequired();

         var technician = modelBuilder.Entity<Technician>();
         technician.Property(t => t.Experience).IsRequired().HasMaxLength(400);
         technician.Property(t => t.Qualification).IsRequired().HasMaxLength(300);

         var administrator = modelBuilder.Entity<Manager>();
         administrator.Property(a => a.Education).IsRequired().HasMaxLength(400);
         administrator.Property(a => a.Position).IsRequired().HasMaxLength(50);


         var driver = modelBuilder.Entity<Driver>();
         driver.Property(d => d.LicenseCategory).IsRequired().HasMaxLength(10);
         driver.Property(d => d.LicenseNumbers).IsRequired().HasMaxLength(12);


         modelBuilder.Entity<Driver>().ToTable("Drivers");
         modelBuilder.Entity<Technician>().ToTable("Technicians");
         modelBuilder.Entity<Manager>().ToTable("Managers");
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer(@"server=localhost;database=AutoCenter;uid=SA;pwd=Ledzeppelin987");
      }

      public DbSet<Car> Cars { get; set; }
      public DbSet<CarType> CarTypes { get; set; }
      public DbSet<Employee> Employees { get; set; }
      public DbSet<Driver> Drivers { get; set; }
      public DbSet<Technician> Technicians { get; set; }
      public DbSet<Manager> Administrators { get; set; }
      public DbSet<Customer> Customers { get; set; }
      public DbSet<Order> Orders { get; set; }
      public DbSet<OrderDetails> OrderDetails { get; set; }
   }
}