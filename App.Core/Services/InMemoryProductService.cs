using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
//using System.AppWindows.Forms;

namespace App.Core.Services
{


    public class InMemoryProductService : IProductService
    {
        private List<Product> _products;
        public InMemoryProductService() {
            _products = new List<Product>();
            GenerateFakeProducts();
        }
        public Product Add(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            return false;
        }

        public bool Delete(string id)
        {
            return false;
        }

        public Product GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }

        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            throw new NotImplementedException();
        }
        public void GenerateFakeProducts()
        {
            _products.Clear();
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Laptop",
                Category = ProductCategoryEnum.Electronics,
                Stock = 10,
               
                Price = 150000.00m,
                 Status = ProductStatusEnum.Active
            });

            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Usb-C Cable",
                Category = ProductCategoryEnum.Electronics,
                Status = ProductStatusEnum.Active,
                Price = 1200m,
                Stock = 18

            });
        }
        private string GenerateId()
        {
            // e.g., P-1A2B3C
            return "P-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }

    }
}
