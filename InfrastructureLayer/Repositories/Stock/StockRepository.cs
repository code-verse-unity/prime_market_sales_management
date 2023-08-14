using DomainLayer.Models.StockModel;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repositories.Stock
{
    class StockRepository : BaseRepository, IStockRepository
    {
        // works if the quantity is less or equal to the stock
        public void RemoveQuantity(int productId, int quantity)
        {
            IEnumerable<IStockModel> stocks = GetByProductId(productId);
            List<StockModel> toDelete = new List<StockModel>();
            List<StockModel> toUpdate = new List<StockModel>();
            
            foreach (StockModel stock in stocks)
            {
                if (quantity > 0)
                {
                    int diff = stock.Quantity - quantity;

                    if (diff > 0)
                    {
                        stock.Quantity = diff;
                        quantity = 0;
                        toUpdate.Add(stock);
                    } else
                    {
                        quantity = Math.Abs(diff);
                        toDelete.Add(stock);
                    }
                } else
                {
                    break;
                }
            }

            foreach (StockModel stock in toDelete)
            {
                Delete(stock);
            }

            foreach (StockModel stock in toUpdate)
            {
                Update(stock);
            }
        }

        public IEnumerable<IStockModel> GetByProductId(int productId)
        {
            List<StockModel> result = new List<StockModel>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    string query = @"SELECT
                        *
                    FROM stock
                    WHERE
                        product_id = @ProductId
                    AND
                        (
                            expiration_date = NULL
                        OR
                            DATE(expiration_date) > CURRENT_DATE
                        )
                    ORDER BY
                        expiration_date ASC,
                        id ASC;";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            result = CreateStocksFromDataReader(reader);
                        }

                    }

                    connection.Close();
                }

            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            return result;
        }

        private List<StockModel> CreateStocksFromDataReader(SQLiteDataReader reader)
        {
            List<StockModel> result = new List<StockModel>();

            while (reader.Read())
            {
                result.Add(new StockModel
                {
                     Id = reader.GetInt32(reader.GetOrdinal("id")),
                     CreatedAt = reader.GetDateTime(reader.GetOrdinal("created_at")),
                     ExpirationDate = !reader.IsDBNull(reader.GetOrdinal("expiration_date")) ? reader.GetDateTime(reader.GetOrdinal("expiration_date")) : (DateTime?)null,
                     ProductId = reader.GetInt32(reader.GetOrdinal("product_id")),
                     Quantity = reader.GetInt32(reader.GetOrdinal("quantity")),
                });
            }

            return result;
        }

        public void Delete(IStockModel stock)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    string query = @"DELETE
                    FROM stock
                    WHERE
                        id = @Id;";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", stock.Id);
                        cmd.ExecuteNonQuery();
                    }

                    connection.Close();
                }

            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Update(IStockModel stock)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    string query = @"UPDATE
                    stock
                    SET
                        quantity = @Quantity,
                        expiration_date = @ExpirationDate,
                        product_id = @ProductId
                    WHERE
                        id = @Id;";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", stock.Id);
                        cmd.Parameters.AddWithValue("@Quantity", stock.Quantity);
                        cmd.Parameters.AddWithValue("@ExpirationDate", stock.ExpirationDate);
                        cmd.Parameters.AddWithValue("@ProductId", stock.ProductId);
                        cmd.ExecuteNonQuery();
                    }

                    connection.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
