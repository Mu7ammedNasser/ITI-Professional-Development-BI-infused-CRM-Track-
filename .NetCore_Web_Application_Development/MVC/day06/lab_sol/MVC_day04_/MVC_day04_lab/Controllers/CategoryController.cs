using Microsoft.AspNetCore.Mvc;
using MVC_day04_lab.Data.Context;
using MVC_day04_lab.Models;
using MVC_day04_lab.ViewModels.Category;



namespace MVC_day04_lab.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationContext db = new ApplicationContext();
        public IActionResult Index()
        {
            var categoryVM = db.Categories
                .Select(c => new CategoryVM
                {
                    Id = c.Id,
                    Name = c.Name
                });
            return View(categoryVM);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(CategoryVM category)
        {
            if(category is not null)
            {
                var categoryDomainModel = new Category
                {
                    Name = category.Name
                };
                db.Categories.Add(categoryDomainModel);
                db.SaveChanges();
            }
                return RedirectToAction("Index");
  

        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var category = db.Categories.FirstOrDefault(c => c.Id == id);
            if (category is null)
            {
                return RedirectToAction("Index");
            }

            var categoryVM = new CategoryVM
            {
                Id = category.Id,
                Name = category.Name
            };

            return View(categoryVM);
        }

        [HttpPost]
        public IActionResult EditCategory(CategoryVM categoryVM)
        {
            if (ModelState.IsValid)
            {
                var category = db.Categories.FirstOrDefault(c => c.Id == categoryVM.Id);
                if (category is null)
                {
                    return RedirectToAction("Index");
                }

                category.Name = categoryVM.Name;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoryVM);
        }

        public IActionResult DeleteCategory(int id)
        {
            var category = db.Categories.FirstOrDefault(c => c.Id == id);
            if (category is null)
            {
                return RedirectToAction("Index");
            }
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
