using DomainLayer.Models.CategoryModel;
using DomainLayer.Models.PriceModel;
using DomainLayer.Models.ProductModel;
using DomainLayer.Models.StockModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        void Add(IProductModel product, IPriceModel price, IStockModel stock);
        void Delete(IProductModel product);
        void Update(IProductModel product);
        IEnumerable<IProductModel> GetAll();
    }
}
