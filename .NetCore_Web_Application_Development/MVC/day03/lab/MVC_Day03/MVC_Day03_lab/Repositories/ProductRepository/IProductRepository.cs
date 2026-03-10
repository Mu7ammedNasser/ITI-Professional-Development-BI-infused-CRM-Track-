
using MVC_day04_lab.Models;

namespace MVC_day04_lab.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct( Product product );
        int Save();
    }
}
