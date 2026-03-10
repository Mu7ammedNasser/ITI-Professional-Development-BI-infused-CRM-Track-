

using MVC_day04_lab.Models;

namespace MVC_day04_lab.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();

        Category? GetById(int categoryId);

        void Insert(Category category);

        void Update(Category category);

        void Delete(Category category) ;

        int Save();

        
    }
}
