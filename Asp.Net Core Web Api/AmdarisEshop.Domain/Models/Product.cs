using System.Collections.Generic;

namespace AmdarisEshop.Domain.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int AvailableQuantity { get; set; }
        public double Price { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
