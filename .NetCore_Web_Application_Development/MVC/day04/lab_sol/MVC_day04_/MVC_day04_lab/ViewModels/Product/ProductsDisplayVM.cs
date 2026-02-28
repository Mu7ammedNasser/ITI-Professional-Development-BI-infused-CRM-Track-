
using System.ComponentModel.DataAnnotations;

namespace MVC_day04_lab.ViewModels.Product
{
    public class ProductsDisplayVM
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public DateOnly? ExpireDate { get; set; }
        public string CategoryName { get; set; }
    }
}
