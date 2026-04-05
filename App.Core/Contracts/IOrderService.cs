using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using App.Core.Utilities;
namespace App.Core.Contracts
{
    public interface IOrderService
    {
        public List<Models.Order> GetAll();
        public Order GetById(string id);

        public void Add(Order order);

        public void Update(Order order);

         public void Delete(string id);

         public List<Order> GetByCustomerId(string customerId);
        public List<Order> GetByStatus(OrderStatusEnum status);
    }
}
