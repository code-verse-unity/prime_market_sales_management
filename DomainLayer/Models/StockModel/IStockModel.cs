using System;

namespace DomainLayer.Models.StockModel
{
    public interface IStockModel
    {
        int Id { get; set; }
        int Quantity { get; set; }
        DateTime? ExpirationDate { get; set; }
        int ProductId { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
