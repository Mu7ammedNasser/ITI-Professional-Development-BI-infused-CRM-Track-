namespace MVC_day04_lab.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        // foreign key

        public DateOnly? ExpireDate { get; set; }
        public int CategoryId { get; set; }
        // navigation property
        public Category Category { get; set; }
    }
}
