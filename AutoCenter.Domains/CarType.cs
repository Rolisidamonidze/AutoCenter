using AutoCenter.Domain.Interfaces;

namespace AutoCenter.Domain
{
   public class CarType: IIdentity
   {
      public int ID { get; set; }
      public string Name { get; set; }
      public int TechnicianID { get; set; }
      public Technician Technician { get; set; }
   }
}