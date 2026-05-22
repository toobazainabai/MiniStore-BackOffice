using System;
using System.Collections.Generic;
using System.Linq;
using App.Core.Contracts;
using App.Core.Models;
using Microsoft.Data.SqlClient;

namespace App.Core.Services
{
    public class DbCustomerService : ICustomerService
    {
        private readonly string _connectionString;

        public DbCustomerService(string connString)
        {
            _connectionString = connString;
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.Id = reader.GetString(reader.GetOrdinal("Id"));
                        customer.Name = reader["Name"].ToString();
                        customer.Address = reader["Address"].ToString();
                        customer.Phone = reader["Phone"].ToString();
                        customer.Email = reader["Email"].ToString();
                        customers.Add(customer);
                    }
                }
            }
            return customers;
        }

        public Customer GetById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Customer ID cannot be null or empty", nameof(id));

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.Id = reader.GetString(reader.GetOrdinal("Id"));
                        customer.Name = reader["Name"].ToString();
                        customer.Address = reader["Address"].ToString();
                        customer.Phone = reader["Phone"].ToString();
                        customer.Email = reader["Email"].ToString();
                        return customer;
                    }
                }
            }
            return null;
        }

        public void Add(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer), "Customer object is null");

            customer.Id = Guid.NewGuid().ToString("N").Substring(0, 9);
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Customer(Id, Name, Address, Phone, Email) VALUES (@Id, @Name, @Address, @Phone, @Email)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.Name ?? string.Empty);
                cmd.Parameters.AddWithValue("@Address", customer.Address ?? string.Empty);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone ?? string.Empty);
                cmd.Parameters.AddWithValue("@Email", customer.Email ?? string.Empty);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer), "Customer object is null");

            if (string.IsNullOrWhiteSpace(customer.Id))
                throw new ArgumentException("Customer ID cannot be null or empty", nameof(customer));

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "UPDATE Customer SET Name = @Name, Address = @Address, Phone = @Phone, Email = @Email WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.Name ?? string.Empty);
                cmd.Parameters.AddWithValue("@Address", customer.Address ?? string.Empty);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone ?? string.Empty);
                cmd.Parameters.AddWithValue("@Email", customer.Email ?? string.Empty);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Customer ID cannot be null or empty", nameof(id));

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Customer WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Customer> SearchOption(string query)
        {
            List<Customer> customers = new List<Customer>();

            if (string.IsNullOrWhiteSpace(query))
                return GetAll();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                string sql = "SELECT * FROM Customer WHERE Name LIKE @Query OR Email LIKE @Query OR Phone LIKE @Query";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@Query", $"%{query}%");

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.Id = reader.GetString(reader.GetOrdinal("Id"));
                        customer.Name = reader["Name"].ToString();
                        customer.Address = reader["Address"].ToString();
                        customer.Phone = reader["Phone"].ToString();
                        customer.Email = reader["Email"].ToString();
                        customers.Add(customer);
                    }
                }
            }
            return customers;
        }
    }
}
