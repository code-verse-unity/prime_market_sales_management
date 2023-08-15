using DomainLayer.Models.ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.ProductPurchaseModel
{
    public interface IProductPurchaseModel
    {
        int Id { get; set; }
        int ProductId { get; set; }
        int PurchaseId { get; set; }
        int Quantity { get; set; }
        double Price { get; set; }
        double SubTotal { get; }
        IProductModel Product { get; set; }
    }
}
