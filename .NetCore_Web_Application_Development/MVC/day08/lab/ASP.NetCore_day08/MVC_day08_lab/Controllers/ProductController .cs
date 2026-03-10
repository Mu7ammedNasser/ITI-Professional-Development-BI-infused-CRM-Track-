using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_day04_lab.Data.Context;
using MVC_day04_lab.Models;
using MVC_day04_lab.Repositories.CategoryRepository;
using MVC_day04_lab.Repositories.ProductRepository;
using MVC_day04_lab.ViewModels;
using MVC_day04_lab.ViewModels.Product;



namespace MVC_day04_lab.Controllers
{
    public class ProductController : Controller
    {
        // data access
        //private readonly ApplicationContext db = new ApplicationContext();

        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        public ProductController(IProductRepository productRepository,
            ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        /// secuirty wise we should not expose our domain model directly
        /// to the view, because it may contain sensitive data
        /// or business logic that we do not want to expose to the user.
        /// avoid sql injection attacks by not exposing the domain model directly to the view, as it may contain properties that can be manipulated by the user to execute malicious SQL commands.

        /// also we use view models to add props that
        /// are not in the domain model but are needed for the view,
        /// such as CategoryName in this example.
        /// or to hide props that are in the domain model but are not needed for the view,
        public IActionResult Index()
        {
            var productsReadVM = _productRepository.GetAllProducts()
                .Select(p => new ProductsDisplayVM
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    Count = p.Count,
                    ExpireDate = p.ExpireDate,
                    ImageURL = p.ImageURL,
                    CategoryName = p.Category.Name
                });

            return View(productsReadVM);
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
                CategoryName = product.Category.Name,
                Count = product.Count,
                ExpireDate = product.ExpireDate,
                ImageURL = product.ImageURL

            };
            return View(productDisplayVM);
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            var productVM = new ProductVM
            {
                Categories = GetDepartmentsForDropDown()

            };
            return View(productVM);
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductVM productCreateVM)
        {
            if (!ModelState.IsValid)
            {
                productCreateVM.Categories = GetDepartmentsForDropDown();
                return View(productCreateVM);
            }

            // create unique name for the image to avoid conflicts when saving it to the server
            var uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetExtension(productCreateVM.Image.FileName);

            // define path to save the image on the server
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", "Products");

            // create the folder if it doesn't exist
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, uniqueFileName);

            // save the image to the server
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                productCreateVM.Image.CopyTo(stream);
            }

            var productToDomain = new Product
            {
                Name = productCreateVM.Name!,
                Price = productCreateVM.Price ?? 0,
                Description = productCreateVM.Description,
                Count = productCreateVM.Count ?? 0,
                CategoryId = productCreateVM.CategoryId,
                ExpireDate = productCreateVM.ExpireDate,
                ImageURL = uniqueFileName // save the relative path to the image in the database


            };
            _productRepository.AddProduct(productToDomain);
            _productRepository.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var productToUpdate = _productRepository.GetProductById(id);
            if (productToUpdate == null) return RedirectToAction("Index");

            // map from domian to view model 

            var productVM = new ProductVM
            {
                Id = productToUpdate.Id,
                Name = productToUpdate.Name,
                Price = productToUpdate.Price,
                Description = productToUpdate.Description,
                Count = productToUpdate.Count,
                CategoryId = productToUpdate.CategoryId,
                Categories = GetDepartmentsForDropDown(),
                ExpireDate = productToUpdate.ExpireDate
            };

            return View(productVM);
        }
        [HttpPost]
        public IActionResult Edit(ProductVM product)
        {
            if (!ModelState.IsValid)
            {
                product.Categories = GetDepartmentsForDropDown();
                return View(product);
            }

            var productToUpdate = _productRepository.GetProductById(product.Id ?? 0);
            if (productToUpdate == null) return RedirectToAction("Index");
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price ?? 0;
            productToUpdate.Description = product.Description;
            productToUpdate.Count = product.Count ?? 0;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ExpireDate = product.ExpireDate;

            _productRepository.UpdateProduct(productToUpdate);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var ProductToDelete = _productRepository.GetProductById(id);
            if (ProductToDelete == null)
            {
                return RedirectToAction("Index");
            }

            _productRepository.DeleteProduct(ProductToDelete);
            _productRepository.Save();

            return RedirectToAction("Index");

        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult CheckName(string Name)
        {
            var isExist = _productRepository.GetPRoductByName(Name);
            if (isExist)
            {
                return Json($"Name '{Name}' already exists");
            }
            return Json(true);
        }


        private List<SelectListItem> GetDepartmentsForDropDown()
        {
            return _categoryRepository.GetAll()
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList();
        }

    }
}