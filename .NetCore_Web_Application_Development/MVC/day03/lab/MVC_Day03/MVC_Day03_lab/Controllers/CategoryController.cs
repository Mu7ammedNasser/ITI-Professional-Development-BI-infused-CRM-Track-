using Microsoft.AspNetCore.Mvc;
using MVC_Day03_lab.Data.Context;
using MVC_Day03_lab.Models;

namespace MVC_Day03_lab.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationContext db = new ApplicationContext();
        public IActionResult Index()
        {
            var categories = db.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            if (category is not null)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var category = db.Categories.FirstOrDefault(c => c.Id == id);
            if (category is null)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult EditCategory(Category category)
        {
            if (category is not null)
            {
                db.Categories.Update(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
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
