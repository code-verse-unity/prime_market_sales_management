using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.RevenueModel
{
    public class RevenueModel : IRevenueModel
    {
        public double Amount {get; set;}

        public int Month {get; set;}

        public int Year {get; set;}
    }
}
