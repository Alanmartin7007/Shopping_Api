using System.ComponentModel.DataAnnotations;

namespace ShoppingApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime ManufacturedDate { get; set; }
        [Url]
        public string ImageUrl { get; set; }
    }
}
