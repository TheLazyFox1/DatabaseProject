using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TechSprint2.Models
{
    public class Customers
    {
        [DisplayName("Laptop Name")]
        [Required]
        public string LaptopName { get; set; }

        [Key]
        [DisplayName("Serial Number")]
        public string SerialNumber { get; set; }

        [DisplayName("Purchase Time")]
        public DateTime PurchaseTime { get; set; }

        [DisplayName("Brand")]
        [Required]
        public string Brand { get; set; }

        [DisplayName("Model")]
        public string Model { get; set; }

        [DisplayName("Price")]
        public float Price { get; set; }
    }
}
