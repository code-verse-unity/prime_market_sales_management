using DomainLayer.Models.ProductPurchaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.PurchaseModel
{
    public class PurchaseModel: IPurchaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<IProductPurchaseModel> ProductPurchases { get; set; }
        public double Total => CalculateTotal();

        public int ProductsCount => CalculateProductsCount();

        private int CalculateProductsCount()
        {
            int result = 0;

            foreach (IProductPurchaseModel ProductPurchase in ProductPurchases)
            {
                result += ProductPurchase.Quantity;
            }

            return result;
        }

        private double CalculateTotal()
        {
            double result = 0;

            foreach (IProductPurchaseModel ProductPurchase in ProductPurchases)
            {
                result += ProductPurchase.SubTotal;
            }

            return result;
        }
    }
}
