using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_day04_lab.CustomValidators;

namespace MVC_day04_lab.ViewModels.Product
{
    public class ProductVM
    {
        public int? Id { get; set; }
        #region Get From Form

        [MinLength(3)]
        [MaxLength(20 )]
        [Required]
        [Remote(action: "CheckName", controller: "Product", ErrorMessage = "Name already Exist") ] // to check if the name is unique, and pass the Id to exclude the current product when editing
        public string Name { get; set; }

        [Required]
        public decimal? Price { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public int? Count { get; set; }

        [DataType(DataType.Date)] // to specify that this property should be treated as a date
        [Expired] // custom validation attribute to check if the product is expired
        public DateOnly? ExpireDate { get; set; }

        [Required]
        public int CategoryId { get; set; }
        #endregion

        #region Send To From 
        public List<SelectListItem>? Categories { get; set; } = new List<SelectListItem>();

        #endregion



    }
}
