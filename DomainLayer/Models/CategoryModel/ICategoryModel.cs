using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.CategoryModel
{
    public interface ICategoryModel
    {
        int Id { get; set; }
        string Name { get; set; }
        int RayNumber { get; set; }
    }
}
