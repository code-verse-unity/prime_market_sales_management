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
    }
}
