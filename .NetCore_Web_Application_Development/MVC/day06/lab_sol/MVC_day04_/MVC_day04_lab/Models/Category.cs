namespace MVC_day04_lab.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // navigation property
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
