using DomainLayer.Models.CategoryModel;
using System.Collections.Generic;

namespace InfrastructureLayer.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        void Add(ICategoryModel category);
        void Delete(ICategoryModel category);
        void Update(ICategoryModel category);
        IEnumerable<ICategoryModel> GetAll();
    }
}
