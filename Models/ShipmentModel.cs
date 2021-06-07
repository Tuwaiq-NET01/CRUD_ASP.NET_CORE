using System;
namespace CRUD_with_ASP.NET.Models
{
    public class ShipmentModel
    {
        public int Id { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public string LocationOfDelivery { get; set; }
    }
}
