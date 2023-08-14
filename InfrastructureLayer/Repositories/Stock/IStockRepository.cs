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
        void Add(IStockModel stock);
    }
}
