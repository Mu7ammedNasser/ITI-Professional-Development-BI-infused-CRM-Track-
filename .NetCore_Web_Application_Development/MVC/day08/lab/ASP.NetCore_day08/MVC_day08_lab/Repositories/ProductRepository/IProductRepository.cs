
using MVC_day04_lab.Models;

namespace MVC_day04_lab.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product? GetProductById(int id);
        
        bool GetPRoductByName(string name);

        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct( Product product );

        int Save();
    }
}
