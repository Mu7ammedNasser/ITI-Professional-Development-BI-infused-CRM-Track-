using day2_MVC_lab.Models;
using day2_MVC_lab.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace day2_MVC_lab.Controllers
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

        #region GetAll
        public IActionResult GetAll()
        {
            List<ProductVM> productsVM = products.Select(p=> new ProductVM
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Price = p.Price
            }).ToList();



            return View(productsVM);
        }

        #endregion

        #region GetById
        public IActionResult GetById(int id )
        {
            var prodduct = products.FirstOrDefault(p => p.Id == id);
            if(prodduct == null)
            {
                return View("NotFounded");
            }
            return View(prodduct);
        }

        #endregion

        #region Create 
        public IActionResult Create()
        {
            return View();
        }   

        public IActionResult ActualCreate(int id ,string title , string description , int price , int count)
        {
            // create new Product
            Product product = new Product()
            {
                Id = id,
                Title = title,
                Description = description,
                Price = price,
                Count = count
            };
            // add it to the database
            products.Add(product);
            // return to the list of products
            return RedirectToAction("GetAll");

        }
        #endregion

        #region Edit
        public IActionResult Edit(int id )
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return View("NotFounded");
            }
            return View(product);
        }

        public IActionResult ActualEdit(int id, string title, string description, decimal price, int count)
        {
            // Edit  Product
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return View("NotFounded");
            }
            product.Title = title;
            product.Description = description;
            product.Price = price;
            product.Count = count;

            // add it to the database
            // return to the list of products
            return RedirectToAction("GetAll");

        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return View("NotFounded");
            }

            products.Remove(product);
             return RedirectToAction("GetAll");

        }
        #endregion
    }
}
