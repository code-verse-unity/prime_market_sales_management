using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.RevenueModel
{
    public interface IRevenueModel
    {
        int Month { get; set; } // ! 1-based index
        int Year { get; set; }
        double Amount { get; set; }
    }
}
