using DomainLayer.Models.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
