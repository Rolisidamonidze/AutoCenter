using AutoCenter.Domain;
using AutoCenter.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.UnitTest.Data
{
   public class Storage
   {
      public Storage()
      {
         Customer customer = new()
         {
            Firstname = "Mariam",
            Lastname = "Tskhovrebashvili",
            Address = "Naxalovka",
            Phone = "555444333"
         };

         Manager manager = new()
         {
            FirstName = "Madona",
            LastName = "Tsutskiridze",
            Education = "TSU",
            Address = "USA",
            Position = "CTO",
         };

         Driver driver = new()
         {
            FirstName = "Misho",
            LastName = "Magaldadze",
            Address = "Ortachala 2",
            LicenseCategory = "B,C",
            LicenseNumbers = "345643234565"
         };

         Technician technician = new()
         {
            FirstName = "Shako",
            LastName = "Kalabegashvili",
            Address = "Ortachala 1",
            Experience = "He Has worked at BMW for 3 years",
            Qualification = "Engine expert"
         };

         CarType carType = new()
         {
            Name = "Sedan",
            Technician = technician
         };

         Car car = new()
         {
            Brand = "BMW",
            Model = "F10",
            Color = "Black",
            PlateNumbers = "si-700-da",
            RentalPrice = 100,
            CarType = carType,
         };

         //Order order = new()
         //{
         //   OrderDate = DateTime.Now,
         //   StartDate = DateTime.Now.AddDays(1),
         //   EndDate = new DateTime(2021, 11, 1),
         //   Customer = customer,
         //   Price = 110.50m,
         //   Driver = driver,
         //};

         Customer = customer;
         Driver = driver;
         Technician = technician;
         Manager = manager;
         //Order = order;
         CarType = carType;
         Car = car;
      }

      public Customer Customer { get; private set; }
      public Driver Driver { get; private set; }
      public Technician Technician { get; private set; }
      public Car Car { get; private set; }
      public Manager Manager { get; private set; }
      public Order Order { get; private set; }
      public CarType CarType { get; private set; }
   }
}
