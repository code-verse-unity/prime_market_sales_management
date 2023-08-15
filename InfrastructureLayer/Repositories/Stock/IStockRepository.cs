using DomainLayer.Models.StockModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Stock
{
    public interface IStockRepository
    {
        void Delete(IStockModel stock);
        void Update(IStockModel stock);
        void RemoveQuantity(int productId, int quantity);
        IEnumerable<IStockModel> GetByProductId(int productId);
        void Add(IStockModel stock);
    }
}
