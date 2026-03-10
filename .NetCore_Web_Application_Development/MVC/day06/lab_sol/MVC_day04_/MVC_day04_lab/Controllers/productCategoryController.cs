using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_day04_lab.Data.Context;
using MVC_day04_lab.ViewModels.ProductCategories;

namespace MVC_day04_lab.Controllers
{
    public class productCategoryController : Controller
    {
        ApplicationContext db = new ApplicationContext();
        public IActionResult AllProductCategories()
        {
            var ProductCAtegoriesVM = new ProductCategoriesVM
            {
                Categories = GetCategoriesForDrobDown()
            };

            return View(ProductCAtegoriesVM);
        }

        private List<SelectListItem> GetCategoriesForDrobDown()
        {
            return db.Categories
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name,
                }).ToList();
        }

        [HttpGet]
        public IActionResult GetProductByCatId(int catid)
        {
            var products = db.Products.Include(p=>p.Category).Where(p => p.CategoryId == catid).Select(p=> new
            ProductCategoryReadVm
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                Count = p.Count,
                ExpireDate = p.ExpireDate,
                Category = p.Category.Name
            }).ToList();

            return PartialView("_ProductsPartialView", products); // no layout because it's a partial view, and we will load it inside another view using AJAX
            //return View("_ProductsPartialView", products); // with layout, but we will load it inside another view using AJAX, so we will see the layout inside the partial view, which is not what we want
        }
    }
}