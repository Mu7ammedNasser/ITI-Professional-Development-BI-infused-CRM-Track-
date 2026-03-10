

using MVC_day04_lab.Models;

namespace MVC_day04_lab.Repositories.CategoryRepository
{
    public interface IDepartmentRepository
    {
        IEnumerable<Category> GetAll();

        Category GetById(int id);

        void Insert(Category category);

        void Update(Category category);

        void Delete(Category category) ;

        int Save();

        
    }
}
