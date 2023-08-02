using System;

namespace DomainLayer.Models.StockModel
{
    internal class StockModel : IStockModel
    {
        public int Id { get; set; }
        public int Quantity { get ; set ; }
        public DateTime ExpirationDate { get ; set ; }
        public int ProductId { get ; set ; }
    }
}
