using Microsoft.AspNetCore.Mvc;
using MVC_lab.Models;

namespace MVC_lab.Controllers
{
    public class ProductController : Controller
    {
        #region Database
        static List<Product> products = new List<Product>()
        {
            new Product(){Id=1, Title="Product 1", Description="Description 1", Price=100, Count=10},
            new Product(){Id=2, Title="Product 2", Description="Description 2", Price=200, Count=20},
            new Product(){Id=3, Title="Product 3", Description="Description 3", Price=300, Count=30},
            new Product(){Id=4, Title="Product 4", Description="Description 4", Price=400, Count=40},
            new Product(){Id=5, Title="Product 5", Description="Description 5", Price=500, Count=50},
            new Product(){Id=6, Title="Product 6", Description="Description 6", Price=600, Count=60},
            new Product(){Id=7, Title="Product 7", Description="Description 7", Price=700, Count=70},
        };
        #endregion

        public IActionResult Index()
        {
            return View();
        }


        #region Get All products
        public IActionResult GetAll()
        {
            return View(products);
        }
        #endregion

        #region get product by id
        public IActionResult GetById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return View("NotFound");
            return View(product);
        }
        #endregion

        #region not founded view 

        #endregion
    }
}
 