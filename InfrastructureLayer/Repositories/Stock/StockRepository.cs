using DomainLayer.Models.StockModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Stock
{
    public class StockRepository : BaseRepository, IStockRepository
    {
        public void Add(IStockModel stock)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string insertStockStatement = "INSERT INTO stock(product_id, quantity, expiration_date, created_at) " +
                   "VALUES(@product_id, @quantity,@expiration_date, @created_at)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertStockStatement, connection))
                    {
                        cmd.CommandText = insertStockStatement;
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@product_id", stock.ProductId);
                        cmd.Parameters.AddWithValue("@quantity", stock.Quantity);
                        cmd.Parameters.AddWithValue("@expiration_date", stock.ExpirationDate.ToString());
                        cmd.Parameters.AddWithValue("@created_at", stock.CreatedAt.ToString());

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
