using MVC_Day03_lab.Models;

namespace MVC_Day03_lab.ViewModels
{
    public class ProductsDisplayVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }

        public int Count { get; set; }
        public Category Category { get; set; }
    }
}
