using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.Core.Services
{
    public class inMemoryCustomerService : ICustomerService
    {
        private readonly List<Customer> _customers = new();

        public List<Customer> GetAll()
        {
            return _customers.ToList();
        }

        public Customer GetById(string id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer), "Customer object is null");

            _customers.Add(customer);
        }

        public void Update(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer), "Customer object is null");

            var existingCustomer = _customers.FirstOrDefault(c => c.Id == customer.Id);
            if (existingCustomer == null)
                throw new ArgumentException($"Customer with {customer.Id} not found");

            existingCustomer.Name = customer.Name;
            existingCustomer.Email = customer.Email;
            existingCustomer.Phone = customer.Phone;
            existingCustomer.Address = customer.Address;
        }

        public void Delete(string id)
        {
            _customers.RemoveAll(c => c.Id == id);
        }

        public List<Customer> SearchOption(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return ((ICustomerService)this).GetAll();

            return _customers
                .Where(c => c.Name != null &&
                            c.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
