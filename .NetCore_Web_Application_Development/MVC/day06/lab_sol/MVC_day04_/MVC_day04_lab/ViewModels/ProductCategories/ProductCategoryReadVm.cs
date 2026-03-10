namespace MVC_day04_lab.ViewModels.ProductCategories
{
    public class ProductCategoryReadVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        // foreign key
        public DateOnly? ExpireDate { get; set; }
        public string? Category { get; set; }
    }
}
