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
            if(product != null)
            {
                product.Id = GenerateId();
                _products.Add(product);
               
            }
            return product;
        }

        public bool Update(Product product)
        {
            if (product != null)
            {
                Product? existing = _products.Find(p => p.Id == product.Id);
                if (existing == null)
                {
                    return false;
                }
                existing.Name = product.Name;
                existing.Category = product.Category;
                existing.Stock = product.Stock;
                existing.Price = product.Price;
                existing.Status = product.Status;
                return true;
            }
            
            return false;
        }
        public bool Delete(string id)
        {
            Product ProductToBeDeleted = GetById(id);
            _products.Remove(ProductToBeDeleted);
            return true;
        }

        public Product GetById(string Id)
        {
            Product? prod = _products.Find(p => p.Id == Id);
            return prod;

        }

        public List<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }

        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            List<Product> _filtered = _products.ToList();
            _filtered = _filtered.Where(p => p.Name.Contains(text)).ToList();
            if (category != null)
            {
                _filtered = _filtered.Where(p => p.Category == category).ToList();
            }

            if (status != null)
            {
                _filtered = _filtered.Where(p => p.Status == status).ToList();
            }
            return _filtered;
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
