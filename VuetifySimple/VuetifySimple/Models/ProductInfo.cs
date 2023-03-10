using System.Net.NetworkInformation;

namespace VuetifySimple.Models
{
    public class ProductInfo
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Calories { get; set; }
        public decimal Fat { get; set; }
        public int Carbs { get; set; }
        public decimal Protein { get; set; }
    }
}