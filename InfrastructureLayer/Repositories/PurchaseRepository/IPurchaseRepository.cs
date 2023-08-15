using DomainLayer.Models.PurchaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.PurchaseRepository
{
    public interface IPurchaseRepository
    {
        void Add(IPurchaseModel purchase);
        void Delete(IPurchaseModel purchase);
        void Update(IPurchaseModel purchase);
        IEnumerable<IPurchaseModel> GetAll();
        IEnumerable<IPurchaseModel> GetAllByDate(DateTime datetime);
    }
}
