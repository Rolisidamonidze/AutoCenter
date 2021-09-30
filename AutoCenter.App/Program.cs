using System;
using System.Linq;
using AutoCenter.Domain;
using AutoCenter.Repository;

namespace AutoCenter.App
{
   class Program
   {
      static void Main(string[] args)
      {
         using (var context = new Repository.AppContext())
         {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //var car = new Car()
            //{
            //   Brand = "Mercedes",
            //   Class = "CLS",
            //   Model = "500",
            //   Color = "White",
            //   PlateNumbers = "si-400-da",
            //   RentalPrice = 400,
            //};

            //Customer customer = new Customer
            //{
            //   Firstname = "Zura",
            //   Lastname = "Chachava",
            //   Address = "Tbilisi"
            //};


            //context.Cars.Add(car);

            //var order = new Order
            //{
            //   CustomerID = context.Customers.FirstOrDefault(c => c.Firstname == "Zura" && c.Lastname == "Chachava").ID
            //};

            //context.Add(order);

            //context.Drivers.Add(new Driver
            //{
            //   FirstName = "Zura",
            //   LastName = "Chachava"
            //});

            context.SaveChanges();
         }
      }
   }
}
