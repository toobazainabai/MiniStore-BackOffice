using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace App.Core.Services
{
    public class InMemoryOrderService : IOrderService
    {
        private  List<Order> _orders;

         InMemoryOrderService() {
            _orders = new List<Order>();
                }
         List<Order> IOrderService.GetAll()
        {
            return _orders.ToList();
        }
         void IOrderService.Add(Order order)
        {
           if(order==null)
                throw new ArgumentNullException("Order is null");
           _orders.Add(order);
        }

         void IOrderService.Delete(string id)
        {
            _orders.RemoveAll(o => o.Id == id);
        }


        Order IOrderService.GetById(string id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }

        List<Order> IOrderService.GetByStatus(OrderStatusEnum status)
        {
            return _orders.Where(order => order.Status == status).ToList();
        }

        List<Order> IOrderService.GetByCustomerId(string customerId)
        {
            return _orders.Where(order => order.Customerid == customerId).ToList();
        }

       

        void IOrderService.Update(Order order)
        {
            var existing =_orders.FirstOrDefault(o=>o.Id == order.Id);
            if (existing != null)
            {
                throw new Exception($"Order with Id= {order.Id} not found");
            }
            existing.Customerid = order.Customerid;
            existing.CustomerName = order.CustomerName;
            existing.OrderDate = order.OrderDate;
            existing.Status = order.Status;
            existing.PaymentMethod= order.PaymentMethod;
            existing.Items=order.Items;
        }
    }
}
