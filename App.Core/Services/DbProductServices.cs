using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using Microsoft.Data.SqlClient;

namespace App.Core.Services
{
    public class DbProductService : IProductService
    {
        private readonly String _connectionString;
        public DbProductService(String connString)
        {
            _connectionString = connString;
        }

        Product IProductService.Add(Product product)
        {
            product.Id=Guid.NewGuid().ToString("N").Substring(0,6).ToUpper();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                String sql= "INSERT INTO Product(Id, Name, Category, Price, Stock, Status) VALUES (@Id, @Name, @Category, @Price, @Stock, @Status)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Category", product.Category.ToString());
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Status", product.Status.ToString());
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    return product;
                }
                else
                {
                    return null;
                }
            }
            
            
            
        }
        bool IProductService.Delete(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                String sql = "DELETE FROM Product WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        List<Product> IProductService.GetAll()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        {
                            Product prod = new Product();
                            prod.Id = reader.GetString(reader.GetOrdinal("Id"));
                            prod.Name = reader["Name"].ToString();
                            String catStr = reader["Category"].ToString();
                            prod.Category = Enum.TryParse<ProductCategoryEnum>(catStr, ignoreCase: true, out var catParsed) ? catParsed : ProductCategoryEnum.None;
                            prod.Price = Convert.ToDecimal(reader["Price"]);
                            prod.Stock = reader.GetInt32(reader.GetOrdinal("Stock"));
                            String statusStr = reader["Status"].ToString();

                            prod.Status = Enum.TryParse<ProductStatusEnum>(statusStr, ignoreCase: true, out var statusParsed) ? statusParsed : ProductStatusEnum.Active;
                            products.Add(prod);
                        }
                    }
                }

            return products;
        }

        Product IProductService.GetById(string id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Product prod = new Product();
                        prod.Id = reader.GetString(reader.GetOrdinal("Id"));
                        prod.Name = reader["Name"].ToString();
                        String catStr = reader["Category"].ToString();
                        prod.Category = Enum.TryParse<ProductCategoryEnum>(catStr, ignoreCase: true, out var catParsed) ? catParsed : ProductCategoryEnum.None;
                        prod.Price = Convert.ToDecimal(reader["Price"]);
                        prod.Stock = reader.GetInt32(reader.GetOrdinal("Stock"));
                        String statusStr = reader["Status"].ToString();
                        prod.Status = Enum.TryParse<ProductStatusEnum>(statusStr, ignoreCase: true, out var statusParsed) ? statusParsed : ProductStatusEnum.Active;
                        return prod;
                    }
                }
            }
            return null;
        }

        List<Product> IProductService.Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            List<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                
                string sql = "SELECT * FROM Product WHERE NAME LIKE @Text";
                
                if(category != null)
                {
                    sql += " AND Category = @Category";
                }
                if(status != null)
                {
                    sql += " AND Status = @Status";
                }
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Text", $"%{text ?? string.Empty}%");
                if(category != null)
                {
                    cmd.Parameters.AddWithValue("@Category", category.Value.ToString());
                }
                if(status != null)
                {
                    cmd.Parameters.AddWithValue("@Status", status.Value.ToString());
                }
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product prod = new Product();
                        prod.Id = reader.GetString(reader.GetOrdinal("Id"));
                        prod.Name = reader["Name"].ToString();
                        string catStr = reader["Category"].ToString();
                        prod.Category = Enum.TryParse<ProductCategoryEnum>(catStr, ignoreCase: true, out var catParsed) ? catParsed : ProductCategoryEnum.None;
                        prod.Price = Convert.ToDecimal(reader["Price"]);
                        prod.Stock = reader.GetInt32(reader.GetOrdinal("Stock"));
                        string statusStr = reader["Status"].ToString();
                        prod.Status = Enum.TryParse<ProductStatusEnum>(statusStr, ignoreCase: true, out var statusParsed) ? statusParsed : ProductStatusEnum.Active;
                        products.Add(prod);
                    }
                }
            }

            return products;
        }

        bool IProductService.Update(Product product)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                String sql = "UPDATE Product SET Name = @Name, Category = @Category, Price = @Price, Stock = @Stock, Status = @Status WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Category", product.Category.ToString());
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@Stock", product.Stock);
                cmd.Parameters.AddWithValue("@Status", product.Status.ToString());
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
    }
}
