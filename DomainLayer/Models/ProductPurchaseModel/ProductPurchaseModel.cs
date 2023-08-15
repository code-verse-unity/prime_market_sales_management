using DomainLayer.Models.ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.ProductPurchaseModel
{
    public class ProductPurchaseModel: IProductPurchaseModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PurchaseId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public IProductModel Product { get; set; }
        public double SubTotal => Price * Quantity;
    }
}
