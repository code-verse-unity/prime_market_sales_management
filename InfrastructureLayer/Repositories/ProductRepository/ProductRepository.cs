using DomainLayer.Models.CategoryModel;
using DomainLayer.Models.PriceModel;
using DomainLayer.Models.ProductModel;
using DomainLayer.Models.StockModel;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace InfrastructureLayer.Repositories.ProductRepository
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public void Add(IProductModel product, IPriceModel price,IStockModel stock)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();

                    // Insert product
                    string insertStatement = "INSERT INTO products(name, is_perishable, unit, category_id, cump) " +
                    "VALUES(@name, @is_perishable, @unit, @category_id, @cump)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertStatement, connection))
                    {
                        cmd.CommandText = insertStatement;
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@name", product.Name);
                        cmd.Parameters.AddWithValue("@is_perishable", product.IsPerishable ? 1 : 0);
                        cmd.Parameters.AddWithValue("@unit", product.Unit);
                        cmd.Parameters.AddWithValue("@category_id", product.CategoryId);
                        cmd.Parameters.AddWithValue("@cump", 0);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }

                    long productId = connection.LastInsertRowId;

                    DateTime now = DateTime.Now;
                    // Insert price
                    string insertPriceStatement = "INSERT INTO price(product_id, unit_price, price_date) " +
                    "VALUES(@product_id, @unit_price, @price_date)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertPriceStatement, connection))
                    {
                        cmd.CommandText = insertPriceStatement;
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@product_id", productId);
                        cmd.Parameters.AddWithValue("@unit_price", price.UnitPrice);
                        cmd.Parameters.AddWithValue("@price_date", now.ToString());

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }

                    // Insert stock
                    string insertStockStatement = "INSERT INTO stock(product_id, quantity, expiration_date, created_at) " +
                    "VALUES(@product_id, @quantity,@expiration_date, @created_at)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertStockStatement, connection))
                    {
                        cmd.CommandText = insertStockStatement;
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@product_id", productId);
                        cmd.Parameters.AddWithValue("@quantity", stock.Quantity);
                        cmd.Parameters.AddWithValue("@expiration_date", stock.ExpirationDate.ToString());
                        cmd.Parameters.AddWithValue("@created_at", now.ToString());

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }

                    // Update CUMP
                    string updateCumpStatement = "UPDATE products SET cump = @cump WHERE id = @productId";
                    using (SQLiteCommand cmd = new SQLiteCommand(updateCumpStatement, connection))
                    {
                        cmd.CommandText = updateCumpStatement;
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@cump", CalculateCump(productId));

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
                catch (SQLiteException e)
                {
                    throw new Exception("Failed opening the database" + e.Message);
                }
            }
        }

        public void Delete(IProductModel product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProductModel> GetAll()
        {
            List<IProductModel> products = new List<IProductModel>();

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string retrieveTotalQuantityQuery = "SELECT products.*, sum(stock.quantity) as quantity from products " +
                        "LEFT JOIN stock on products.id = stock.product_id " +
                        "WHERE deleted_at IS NULL " +
                        "GROUP BY products.id;";

                    using (SQLiteCommand cmd = new SQLiteCommand(retrieveTotalQuantityQuery, connection))
                    {
                        cmd.CommandText = retrieveTotalQuantityQuery;
                        cmd.Prepare();

                        try
                        {
                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    ProductModel product = new ProductModel()
                                    {
                                        Id = int.Parse(reader["id"].ToString()),
                                        Name = reader["name"].ToString(),
                                        Price = Double.Parse(reader["cump"].ToString()),
                                        InStock = int.Parse(reader["quantity"].ToString()),
                                        IsPerishable = int.Parse(reader["is_perishable"].ToString()) == 1,
                                        Unit = reader["unit"].ToString()  
                                    };

                                    products.Add(product);
                                }
                            }

                            connection.Close();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return products;
        }

        public void Update(IProductModel product)
        {
            throw new NotImplementedException();
        }

        private double CalculatetotalQuantityTimesAmount(long productId)
        {
            double totalQuantityTimesAmount = 0;

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string retrieveTotalQuantityQuery = "SELECT stock.quantity as quantity, price.unit_price as price from products " +
                        "LEFT JOIN stock on products.id = stock.product_id " +
                        "LEFT JOIN price on products.id = price.product_id " +
                        "where products.id = @productId;";

                    using (SQLiteCommand cmd = new SQLiteCommand(retrieveTotalQuantityQuery, connection))
                    {
                        cmd.CommandText = retrieveTotalQuantityQuery;
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@productId", productId);

                        try
                        {
                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    totalQuantityTimesAmount += Double.Parse(reader["quantity"].ToString()) * Double.Parse(reader["price"].ToString());
                                }
                            }

                            connection.Close();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return totalQuantityTimesAmount;
        }

        private double CalculateTotalQuantity(long productId)
        {
            double totalQuantity = -1;

            using(SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string retrieveTotalQuantityQuery = "SELECT sum(stock.quantity) as total_quantity from products " +
                        "LEFT JOIN stock on products.id = stock.product_id " +
                        "LEFT JOIN price on products.id = price.product_id " +
                        "where products.id = @productId " +
                        "GROUP by products.id;";

                    using (SQLiteCommand cmd = new SQLiteCommand(retrieveTotalQuantityQuery,connection))
                    {
                        cmd.CommandText = retrieveTotalQuantityQuery;
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@productId", productId);

                        try
                        {
                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    totalQuantity = Double.Parse(reader["total_quantity"].ToString());
                                }
                            }

                            connection.Close();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return totalQuantity;
        }

        private double CalculateCump(long productId)
        {
            return Math.Ceiling(CalculatetotalQuantityTimesAmount(productId) / CalculateTotalQuantity(productId));
        }
    }
}
