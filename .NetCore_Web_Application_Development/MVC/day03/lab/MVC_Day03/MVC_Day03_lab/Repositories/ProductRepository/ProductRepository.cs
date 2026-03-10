using MVC_day04_lab.Data.Context;
using MVC_day04_lab.Models;

namespace MVC_day04_lab.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {

        private readonly ApplicationContext db = new ApplicationContext();
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            
        }

        public void DeleteProduct(Product product)
        {
            db.Products.Remove(product);
        }
          
        public IEnumerable<Product> GetAllProducts()
        {
            return db.Products.ToList();
            // here i use to list to execute the query and get the data from the database, and return it as a list of products.
            // if i return db.Products without to list, it will return an IQueryable<Product> which is a query that has not been executed yet, and it will be executed when we enumerate it in the view or in the controller.
            // so by using to list, we are executing the query and getting the data from the database, and then we can return it as a list of products that can be used in the view or in the controller.
            // what is the difference between returning IQueryable<Product> and List<Product> and what is better?
            // returning IQueryable<Product> allows for deferred execution, meaning that the query will not be executed until it is enumerated. This can be beneficial in scenarios where you want to further filter or manipulate the data before executing the query, as it allows for more efficient querying and reduces unnecessary database calls. However, it can also lead to performance issues if not used carefully, as it may result in multiple database calls if the query is enumerated multiple times.
            // on the other hand, returning List<Product> executes the query immediately and retrieves all the data from the database at once. This can be more efficient in scenarios where you know you will need all the data and want to avoid multiple database calls. However, it can also lead to performance issues if the dataset is large, as it may consume more memory and take longer to retrieve all the data at once.
        }

        public Product GetProductById(int id)
        {
            return db.Products.FirstOrDefault(p=>p.Id == id);
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            /// in entity framework, 
            /// we don't need to write any code to update the product,
            /// because it will track the changes made to the product
            /// and automatically update it when we call save changes.
           
        }
    }
}
