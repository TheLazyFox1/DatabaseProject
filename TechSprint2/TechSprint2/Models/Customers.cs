using System.ComponentModel.DataAnnotations;

namespace TechSprint2.Models
{
    public class Customers
    {
        public string LaptopName { get; set; }
        [Key]
        public string SerialNumber { get; set; }
        public DateTime PurchaseTime { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }

    }
}
