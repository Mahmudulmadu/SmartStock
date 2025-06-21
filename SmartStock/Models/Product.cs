using System.ComponentModel.DataAnnotations;

namespace SmartStock.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be positive.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be non-negative.")]
        public int Quantity { get; set; }
    }
}
