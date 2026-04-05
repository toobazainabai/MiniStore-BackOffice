using System.Collections.Generic;
using App.Core.Models;
using System;


namespace App.Core.Contracts
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(string id);

        void Add(Customer customer);
        void Update(Customer customer);

        void Delete(string id);

        List<Customer> SearchOption(string query);
    }
}
