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
        double Cump { get; set; }
        string Unit { get; set; }   
        DateTime? DeleteAt { get; set; }
    }
}
