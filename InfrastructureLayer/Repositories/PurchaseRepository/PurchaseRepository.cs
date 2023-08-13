using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.PurchaseModel;
using System.Data.SQLite;
using DomainLayer.Models.ProductPurchaseModel;
using DomainLayer.Models.ProductModel;

namespace InfrastructureLayer.Repositories.PurchaseRepository
{
    public class PurchaseRepository : BaseRepository, IPurchaseRepository
    {
        public void Add(IPurchaseModel purchase)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    /*
                        TODO
                        - save product purchases
                    */
                    connection.Open();
                    string insertSPurchasetatement = @"INSERT INTO purchases
                        (created_at)
                    VALUES
                        (@created_at);";

                    using (SQLiteCommand cmd = new SQLiteCommand(insertSPurchasetatement, connection))
                    {
                        cmd.CommandText = insertSPurchasetatement;
                        cmd.Parameters.AddWithValue("@created_at", purchase.CreatedAt);
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                    }

                    int latestPurchaseModelId = GetLatestPurchaseModelId();
                    if (latestPurchaseModelId != -1)
                    {
                        string insertProductPurchaseStatement = @"INSERT INTO product_purchases
                        (
                            product_id,
                            purchase_id,
                            quantity,
                            price
                        )
                        VALUES
                        (
                            @ProductId,
                            @PurchaseId,
                            @Quantity,
                            @Price
                        );";

                        using (SQLiteCommand cmd = new SQLiteCommand(connection))
                        {
                            cmd.CommandText = insertProductPurchaseStatement;

                            SQLiteParameter paramProductId = cmd.Parameters.Add("@ProductId", System.Data.DbType.Int32);
                            SQLiteParameter paramPurchaseId = cmd.Parameters.Add("@PurchaseId", System.Data.DbType.Int32);
                            SQLiteParameter paramQuantity = cmd.Parameters.Add("@Quantity", System.Data.DbType.Int32);
                            SQLiteParameter paramPrice = cmd.Parameters.Add("@Price", System.Data.DbType.Double);

                            cmd.Prepare();

                            foreach (IProductPurchaseModel productPurchaseModel in purchase.ProductPurchases)
                            {
                                paramProductId.Value = productPurchaseModel.ProductId;
                                paramPurchaseId.Value = latestPurchaseModelId;
                                paramQuantity.Value = productPurchaseModel.Quantity;
                                paramPrice.Value = productPurchaseModel.Price;
                                cmd.ExecuteNonQuery();

                                IProductModel product = productPurchaseModel.Product;
                                // TODO update/decrease product.Stock
                            }

                            cmd.Parameters.AddWithValue("@created_at", purchase.CreatedAt);
                        }
                    }

                    connection.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private int GetLatestPurchaseModelId()
        {
            int result = -1;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    string statement = @"SELECT
                        id AS Id
                    FROM purchases
                    ORDER BY
                        created_at DESC,
                        id DESC
                    LIMIT 1;";

                    using (SQLiteCommand cmd = new SQLiteCommand(statement, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result = reader.GetInt32(reader.GetOrdinal("Id"));
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return result;
        } 

        public void Delete(IPurchaseModel purchase)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPurchaseModel> GetAll()
        {
            List<PurchaseModel> categories = new List<PurchaseModel>();

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    /*
                        TODO
                        - add product cump
                        - use product category
                    */
                    connection.Open();
                    string sql = @"SELECT
                        purchases.id AS PurchaseId,
                        purchases.created_at AS PurchaseCreatedAt,
                        product_purchases.id AS ProductPurchaseId,
                        product_purchases.product_id AS ProductPurchaseProductId,
                        product_purchases.purchase_id AS ProductPurchasePurchaseId,
                        product_purchases.quantity AS ProductPurchaseQuantity,
                        product_purchases.price AS ProductPurchasePrice,
                        products.id AS ProductId,
                        products.name AS ProductName,
                        products.category_id AS ProductCategoryId,
                        products.is_perishable AS ProductIsPerishable,
                        products.unit AS ProductUnit,
                        products.deleted_at AS ProductDeletedAt,
                        categories.id AS CategoryId,
                        categories.name AS CategoryName,
                        categories.ray_number AS CategoryRayNumber
                    FROM purchases
                    INNER JOIN product_purchases
                        ON purchases.id = product_purchases.purchase_id
                    INNER JOIN products
                        ON product_purchases.product_id = products.id
                    INNER JOIN categories
                        ON products.category_id = categories.id
                    ORDER BY purchases.created_at ASC;";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            categories = CreatePurchasesFromDataReader(reader);
                        }

                        connection.Close();
                    }

                }
                catch (SQLiteException e)
                {
                    Console.WriteLine("Failed opening the database" + e.Message);
                }
            }

            return categories;
        }

        public void Update(IPurchaseModel purchase)
        {
            throw new NotImplementedException();
        }

        private List<PurchaseModel> CreatePurchasesFromDataReader(SQLiteDataReader reader)
        {
            Dictionary<int, PurchaseModel> dictionary = new Dictionary<int, PurchaseModel>();

            while (reader.Read())
            {
                int purchaseId = reader.GetInt32(reader.GetOrdinal("PurchaseId"));

                if (dictionary.ContainsKey(purchaseId))
                {
                    List<IProductPurchaseModel> newProductPurchases = dictionary[purchaseId].ProductPurchases.ToList();
                    
                    newProductPurchases.Add(new ProductPurchaseModel
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("ProductPurchaseId")),
                        ProductId = reader.GetInt32(reader.GetOrdinal("ProductPurchaseProductId")),
                        Price = reader.GetDouble(reader.GetOrdinal("ProductPurchasePrice")),
                        PurchaseId = reader.GetInt32(reader.GetOrdinal("ProductPurchasePurchaseId")),
                        Quantity = reader.GetInt32(reader.GetOrdinal("ProductPurchaseQuantity")),
                        Product = new ProductModel
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("ProductId")),
                            Name = reader.GetString(reader.GetOrdinal("ProductName")),
                            CategoryId = reader.GetInt32(reader.GetOrdinal("ProductCategoryId")),
                            IsPerishable = reader.GetBoolean(reader.GetOrdinal("ProductIsPerishable")),
                            Unit = reader.GetString(reader.GetOrdinal("ProductUnit")),
                            DeletedAt = !reader.IsDBNull(reader.GetOrdinal("ProductDeletedAt")) ? reader.GetDateTime(reader.GetOrdinal("ProductDeletedAt")) : (DateTime?)null,
                        }
                    });

                    dictionary[purchaseId].ProductPurchases = newProductPurchases;
                } else
                {
                    dictionary.Add(purchaseId, new PurchaseModel
                    {
                        Id = purchaseId,
                        CreatedAt = reader.GetDateTime(reader.GetOrdinal("PurchaseCreatedAt")),
                        ProductPurchases = new List<ProductPurchaseModel>() {
                            new ProductPurchaseModel {
                                Id = reader.GetInt32(reader.GetOrdinal("ProductPurchaseId")),
                                ProductId = reader.GetInt32(reader.GetOrdinal("ProductPurchaseProductId")),
                                Price = reader.GetDouble(reader.GetOrdinal("ProductPurchasePrice")),
                                PurchaseId = reader.GetInt32(reader.GetOrdinal("ProductPurchasePurchaseId")),
                                Quantity = reader.GetInt32(reader.GetOrdinal("ProductPurchaseQuantity")),
                                Product = new ProductModel
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("ProductId")),
                                    Name = reader.GetString(reader.GetOrdinal("ProductName")),
                                    CategoryId = reader.GetInt32(reader.GetOrdinal("ProductCategoryId")),
                                    IsPerishable  = reader.GetBoolean(reader.GetOrdinal("ProductIsPerishable")),
                                    Unit = reader.GetString(reader.GetOrdinal("ProductUnit")),
                                    DeletedAt = !reader.IsDBNull(reader.GetOrdinal("ProductDeletedAt")) ? reader.GetDateTime(reader.GetOrdinal("ProductDeletedAt")) : (DateTime?) null,
                                }
                            }
                        },
                    });
                }
            }

            return dictionary.Values.ToList();
        }
    }
}
