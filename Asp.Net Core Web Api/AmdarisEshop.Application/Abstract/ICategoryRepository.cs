using AmdarisEshop.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmdarisEshop.Application.Abstract
{
    public interface ICategoryRepository
    {
        Task<Category> GetById(int categoryId);

        Task Add(Category category);

        Task Save();

        void Remove(Category category);

        Task<List<Category>> GetAll();

        void Update(Category category);
    }
}