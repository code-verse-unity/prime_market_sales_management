using DomainLayer.Models.CategoryModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace InfrastructureLayer.Repositories.Category
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public void Add(ICategoryModel category)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string insertStatement = "INSERT INTO categories(name, ray_number) " +
                        "VALUES(@name, @ray_number)";


                    using (SQLiteCommand cmd = new SQLiteCommand(insertStatement, connection))
                    {
                        cmd.CommandText = insertStatement;
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@name", category.Name);
                        cmd.Parameters.AddWithValue("@ray_number", category.RayNumber);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }

                        connection.Close();
                    }

                }
                catch (SQLiteException e)
                {
                    throw new Exception("Failed opening the database" + e.Message);
                }
            }
        }

        public void Delete(ICategoryModel category)
        {
            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string deleteStatement = "UPDATE categories SET deleted_at = @delete_at WHERE id = @id";
                    Console.WriteLine(category.Id);

                    using (SQLiteCommand cmd = new SQLiteCommand(deleteStatement, connection))
                    {
                        cmd.CommandText= deleteStatement;
                        cmd.Parameters.AddWithValue("@delete_at", new DateTime());
                        cmd.Parameters.AddWithValue("@id", category.Id);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }

                        connection.Close();
                    }

                }
                catch (SQLiteException e)
                {
                    throw new Exception("Failed opening the database" + e.Message);
                }
            }
        }

        public IEnumerable<ICategoryModel> GetAll()
        {
            List<CategoryModel> categories = new List<CategoryModel>();

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM categories WHERE deleted_at IS NULL";


                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CategoryModel category = new CategoryModel
                                {
                                    Id = Int32.Parse(reader["id"].ToString()),
                                    Name = reader["name"].ToString(),
                                    RayNumber = Int32.Parse(reader["ray_number"].ToString()),
                                };

                                categories.Add(category);
                            }
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

        public ICategoryModel GetById(int categoryId)
        {
            CategoryModel category = new CategoryModel();

            using (SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM categories WHERE id = " + categoryId;


                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                category.Id = categoryId;
                                category.Name = reader["name"].ToString();
                                category.RayNumber = int.Parse(reader["ray_number"].ToString());
                                //category.DeletedAt = DateTime.Parse(reader["deleted_at"].ToString());
                            }
                        }

                        connection.Close();
                    }

                }
                catch (SQLiteException e)
                {
                    Console.WriteLine("Failed opening the database" + e.Message);
                }
            }

            return category;
        }

        public void Update(ICategoryModel category)
        {
            using(SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING))
            {
                try
                {
                    connection.Open();
                    string updateStatement = "UPDATE categories SET name = @name, ray_number = @ray_number " +
                        "WHERE id = @id";

                    using(SQLiteCommand cmd = new SQLiteCommand(updateStatement, connection))
                    {
                        cmd.CommandText = updateStatement;

                        cmd.Parameters.AddWithValue("@id", category.Id);
                        cmd.Parameters.AddWithValue("@name", category.Name);
                        cmd.Parameters.AddWithValue("@ray_number", category.RayNumber);

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
                    Console.WriteLine("Failed opening the database" + e.Message);
                }
            }
        }
    }
}
