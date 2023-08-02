using System;

namespace DomainLayer.Models.PriceModel
{
    public interface IPriceModel
    {
        int Id { get; set; }
        int ProductId { get; set; }
        double UnitPrice { get; set; }
        DateTime Date { get; set; }
    }
}
