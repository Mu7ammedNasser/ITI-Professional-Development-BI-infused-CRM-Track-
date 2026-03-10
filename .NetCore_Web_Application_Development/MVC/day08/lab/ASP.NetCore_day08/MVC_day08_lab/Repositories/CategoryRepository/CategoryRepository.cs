using MVC_day04_lab.Data.Context;
using MVC_day04_lab.Models;

namespace MVC_day04_lab.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {

        //private readonly ApplicationContext db = new ApplicationContext();
        private readonly ApplicationContext db;

        public CategoryRepository(ApplicationContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }
        public Category GetById(int categoryId)
        {
            return db.Categories.FirstOrDefault(c => c.Id == categoryId);
        }

        public void Insert(Category category)
        {
            db.Categories.Add(category);
        }



        public void Update(Category category)
        {
        }

        public void Delete(Category category)
        {
            db.Categories.Remove(category);
        }
        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
