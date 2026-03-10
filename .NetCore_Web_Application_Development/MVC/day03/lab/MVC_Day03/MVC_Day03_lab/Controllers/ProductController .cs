using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Day03_lab.Data.Context;
using MVC_Day03_lab.Models;
using MVC_Day03_lab.ViewModels;
using MVC_day04_lab.Repositories.ProductRepository;


namespace MVC_Day03_lab.Controllers
{
    public class ProductController : Controller
    {
        // data access
        //private readonly ApplicationContext db = new ApplicationContext();

        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAllProducts()
                .Select(p => new ProductsDisplayVM
                {
                    Category = p.Category,
                    Description = p.Description,
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    CategoryName = "" // will be fixed later
                });

            return View(products);
        }
        public IActionResult productDetails(int id)
        {
            /// mapping from domain model to view model
            /// and this useful when we have a complex domain model and we want to display only a part of it in the view,
            /// or when we want to combine data from multiple domain models into a single view model for display purposes.
            /// also it helps to decouple the view from the domain model, allowing for more flexibility in how data is presented and manipulated in the view without affecting the underlying domain logic.
            /// this process can be done manually by creating a new instance of the view model and assigning values from the domain model, or it can be automated using libraries like AutoMapper that can handle the mapping process based on conventions or configurations.
            /// In this example, we are manually mapping the properties of the Product domain model to the ProductsDisplayVM view model, which is then passed to the view for rendering.


            var product = _productRepository.GetProductById(id);

            if (product == null)
            {
                return RedirectToAction("Index");
            }

            var productDisplayVM = new ProductsDisplayVM
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CategoryName = product.Category != null ? product.Category.Name : "No Category",
                Count = product.Count,
            };

            return View(productDisplayVM);
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            var categories = db.Categories.ToList();
            ViewBag.Categories = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var productToUpdate = db.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
            if (productToUpdate == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Categories = new SelectList(db.Categories, "Id", "Name");

            return View(productToUpdate);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
             
            var productToUpdate = db.Products.Include(p=>p.Category).FirstOrDefault(p => p.Id == product.Id);
            if (productToUpdate == null) return RedirectToAction("Index");
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            productToUpdate.Description = product.Description;
            productToUpdate.Count = product.Count;
            productToUpdate.CategoryId = product.CategoryId;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id )
        {
            var ProductToDelete  = db.Products.FirstOrDefault(p => p.Id == id);
            if(ProductToDelete == null)
            {
                 return RedirectToAction("Index");
            }
            db.Products.Remove(ProductToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");

        }





    }
}
