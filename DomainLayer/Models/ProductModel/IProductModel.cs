using DomainLayer.Models.CategoryModel;
using System;

namespace DomainLayer.Models.ProductModel
{
    public interface IProductModel
    {
        int Id { get; set; }
        string Name { get; set; }
        int Stock { get; set; } // TODO correct
        int CategoryId { get; set; }
        bool IsPerishable { get; set; }
        DateTime DeletedAt { get; set; }
        string Unit { get; set; }
        double Price { get; set; } // CUMP
        int InStock { get; set; }
        ICategoryModel Category { get; set; }
    }
}
