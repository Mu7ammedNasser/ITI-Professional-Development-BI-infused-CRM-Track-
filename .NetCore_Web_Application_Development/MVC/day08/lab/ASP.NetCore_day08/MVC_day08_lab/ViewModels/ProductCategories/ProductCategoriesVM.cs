using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_day04_lab.ViewModels.ProductCategories
{
    public class ProductCategoriesVM
    {
        [Required]
        public int CategoryId { get; set; }
        public List<SelectListItem>? Categories { get; set; }
    }
}
