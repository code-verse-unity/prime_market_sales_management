using DomainLayer.Models.PriceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Price
{
    public interface IPriceRepository
    {
        void Add(IPriceModel price);
    }
}
