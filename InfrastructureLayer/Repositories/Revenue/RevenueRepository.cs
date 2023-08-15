using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.RevenueModel;
using System.Data.SQLite;

namespace InfrastructureLayer.Repositories.Revenue
{
    public class RevenueRepository : BaseRepository, IRevenueRepository
    {
        public IEnumerable<IRevenueModel> GetAllByYear(int year)
        {
            List<RevenueModel> result = new List<RevenueModel>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    // Insert product
                    string query = @"SELECT
                        strftime('%m', purchases.created_at) AS Month,
                        IFNULL(SUM(product_purchases.price * product_purchases.quantity), 0) AS Amount,
                        strftime('%Y', purchases.created_at) AS Year
                    FROM product_purchases
                    INNER JOIN purchases
                    ON
                        product_purchases.purchase_id = purchases.id
                        WHERE strftime('%Y', purchases.created_at) = @year
                    GROUP BY Month, Year
                    ORDER BY Year DESC, Month ASC;";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.CommandText = query;
                        cmd.Prepare();

                        string a = year.ToString();

                        cmd.Parameters.AddWithValue("@year", year.ToString());

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            result = CreateRevenueModelFromReader(reader);
                        }
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return result;
        }

        private List<RevenueModel> CreateRevenueModelFromReader(SQLiteDataReader reader)
        {
            List<RevenueModel> result = new List<RevenueModel>();

            while (reader.Read())
            {
                result.Add(new RevenueModel
                {
                        Amount = reader.GetDouble(reader.GetOrdinal("Amount")),
                        Month = Convert.ToInt32(reader["Month"].ToString()),
                        Year = Convert.ToInt32(reader["Year"].ToString()),
                });
            }

            return result;
        }
    }
}
