using System.ComponentModel.DataAnnotations;

namespace MVC_day04_lab.ViewModels.Category
{
    public class CategoryVM
    {
        public int Id { get; set; }

        [Display(Name = "Category Name")] // this is used to change the label of the input field in the view
        public required string Name { get; set; }
    }
}

