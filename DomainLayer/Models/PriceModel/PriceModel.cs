using System;

namespace DomainLayer.Models.PriceModel
{
    public class PriceModel : IPriceModel
    {
        public int Id { get; set; }
        public int ProductId { get ; set; }
        public double UnitPrice { get; set; }
        public DateTime Date { get; set ; }
    }
}
