using DomainLayer.Models.RevenueModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Revenue
{
    public interface IRevenueRepository
    {
        IEnumerable<IRevenueModel> GetAllByYear(int year);
    }
}
