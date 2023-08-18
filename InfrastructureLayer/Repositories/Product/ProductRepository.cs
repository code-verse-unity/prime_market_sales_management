using DomainLayer.Models.CategoryModel;
using DomainLayer.Models.PriceModel;
using DomainLayer.Models.ProductModel;
using DomainLayer.Models.StockModel;
using InfrastructureLayer.Repositories.Category;
using InfrastructureLayer.Repositories.Price;
using InfrastructureLayer.Repositories.Stock;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;

namespace InfrastructureLayer.Repositories.Product
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public void Add(IProductModel product, IPriceModel price, IStockModel stock)
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

                    int productId = (int)connection.LastInsertRowId;

                    DateTime now = DateTime.Now;
                    price.Date = now;
                    price.ProductId = productId;
                    new PriceRepository().Add(price);

                    stock.CreatedAt = now;
                    stock.ProductId = productId;
                    new StockRepository().Add(stock);

                    // Update CUMP
                    UpdateCump(productId);

                }
                catch (SQLiteException e)
                {
                    throw new Exception("Failed opening the database" + e.Message);
                }
            }
        }

        public void Delete(IProductModel product)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string deleteStatement = "UPDATE products SET deleted_at = @deletedAt where id = @productId";

                    using (SQLiteCommand cmd = new SQLiteCommand(deleteStatement, connection))
                    {
                        cmd.CommandText = deleteStatement;
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@productId", product.Id);
                        cmd.Parameters.AddWithValue("@deletedAt", DateTime.Now);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public IEnumerable<IProductModel> GetAll()
        {
            List<IProductModel> products = new List<IProductModel>();
            ICategoryRepository categoryRepository = new CategoryRepository();

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string retrieveTotalQuantityQuery = "SELECT products.*, sum(stock.quantity) as quantity from products " +
                        "LEFT JOIN stock on products.id = stock.product_id " +
                        "WHERE products.deleted_at IS NULL " +
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

                                    ProductModel product = new ProductModel();

                                    try
                                    {
                                        product.Id = Convert.ToInt32(reader["id"].ToString());
                                        product.Name = reader.GetString(reader.GetOrdinal("name"));
                                        product.CategoryId = Convert.ToInt32(reader["category_id"].ToString());
                                        product.Price = Convert.ToDouble(reader["cump"].ToString());
                                        product.IsPerishable = Convert.ToInt32(reader["is_perishable"].ToString()) == 1;
                                        product.Unit = reader["unit"].ToString();
                                    }
                                    catch (FormatException ex)
                                    {
                                        // Handle the format exception here
                                        Console.WriteLine("Error: " + ex.Message);
                                    }

                                    product.InStock = CalculateTotalQuantity(product.Id);
                                    product.Category = categoryRepository.GetById(product.CategoryId);

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
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string updateStatement = "UPDATE products SET name = @name, cump = @price, unit = @unit, category_id = @categoryId, is_perishable = @isPerishable " +
                        "WHERE id = @id";

                    using (SQLiteCommand cmd = new SQLiteCommand(updateStatement, connection))
                    {
                        cmd.CommandText = updateStatement;

                        cmd.Parameters.AddWithValue("@id", product.Id);
                        cmd.Parameters.AddWithValue("@name", product.Name);
                        cmd.Parameters.AddWithValue("@unit", product.Unit);
                        cmd.Parameters.AddWithValue("@price", product.Price);
                        cmd.Parameters.AddWithValue("@categoryId", product.Category.Id);
                        cmd.Parameters.AddWithValue("@isPerishable", product.IsPerishable ? 1 : 0);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (SQLiteException e)
                        {
                            Console.WriteLine("Failed opening the database" + e.StackTrace);
                        }
                    }
                }
                catch (SQLiteException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        private double CalculatetotalQuantityTimesAmount(long productId)
        {
            double totalQuantityTimesAmount = 0;

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string retrieveTotalQuantityQuery = "SELECT stock.quantity, price.unit_price as price from stock " +
                       "LEFT JOIN price on price.price_date = stock.created_at "+
                        "WHERE stock.product_id = @productId";

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

        private int CalculateTotalQuantity(long productId)
        {
            int totalQuantity = 0;

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string retrieveTotalQuantityQuery = "SELECT sum(stock.quantity) as total_quantity from products " +
                        "LEFT JOIN stock on products.id = stock.product_id " +
                        "WHERE products.id = @productId " +
                        "GROUP by products.id;";

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
                                    try
                                    {
                                        totalQuantity = Convert.ToInt32(reader["total_quantity"].ToString());
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("id " + productId);
                                    }

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

            return totalQuantity;
        }

        private double CalculateCump(long productId)
        {
            int totalQuantity = CalculateTotalQuantity(productId);

            if (totalQuantity == 0)
            {
                return 0;
            }
            return Math.Ceiling(CalculatetotalQuantityTimesAmount(productId) / totalQuantity);
        }

        public IEnumerable<IProductModel> FindByName(string name)
        {
            List<IProductModel> products = new List<IProductModel>();
            ICategoryRepository categoryRepository = new CategoryRepository();

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string retrieveTotalQuantityQuery = "SELECT products.*, sum(stock.quantity) as quantity from products " +
                        "LEFT JOIN stock on products.id = stock.product_id " +
                        "WHERE products.deleted_at IS NULL AND products.name LIKE '%" + name + "%' " +
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

                                    ProductModel product = new ProductModel();

                                    try
                                    {
                                        product.Id = Convert.ToInt32(reader["id"].ToString());
                                        product.Name = reader.GetString(reader.GetOrdinal("name"));
                                        product.CategoryId = Convert.ToInt32(reader["category_id"].ToString());
                                        product.Price = Convert.ToDouble(reader["cump"].ToString());
                                        product.IsPerishable = Convert.ToInt32(reader["is_perishable"].ToString()) == 1;
                                        product.Unit = reader["unit"].ToString();
                                    }
                                    catch (FormatException ex)
                                    {
                                        // Handle the format exception here
                                        Console.WriteLine("Error: " + ex.Message);
                                    }


                                    product.InStock = CalculateTotalQuantity(product.Id);
                                    product.Category = categoryRepository.GetById(product.CategoryId);

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

        public void UpdateCump(int productId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
