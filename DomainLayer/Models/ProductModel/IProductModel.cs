using DomainLayer.Models.ProductPurchaseModel;
using System;
using System.Collections.Generic;

namespace DomainLayer.Models.ProductModel
{
    public interface IProductModel
    {
        int Id { get; set; }
        string Name { get; set; }
        int CategoryId { get; set; }
        bool IsPerishable { get; set; }
        DateTime DeleteAt { get; set; }
        string Unit { get; set; }
        IEnumerable<IProductPurchaseModel> ProductPurchases { get; set; }
    }
}
