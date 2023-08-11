using DomainLayer.Models.CategoryModel;
using System.Collections.Generic;

namespace InfrastructureLayer.Repositories.Category
{
    public interface ICategoryRepository
    {
        void Add(ICategoryModel category);
        void Delete(ICategoryModel category);
        void Update(ICategoryModel category);
        IEnumerable<ICategoryModel> GetAll();
        ICategoryModel GetById(int categoryId);
    }
}
