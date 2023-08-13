using DomainLayer.Models.PriceModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Price
{
    public class PriceRepository : BaseRepository, IPriceRepository
    {
        public void Add(IPriceModel price)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();

                    string insertPriceStatement = "INSERT INTO price(product_id, unit_price, price_date) " +
                    "VALUES(@product_id, @unit_price, @price_date)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertPriceStatement, connection))
                    {
                        cmd.CommandText = insertPriceStatement;
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@product_id", price.ProductId);
                        cmd.Parameters.AddWithValue("@unit_price", price.UnitPrice);
                        cmd.Parameters.AddWithValue("@price_date", price.Date.ToString());

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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
