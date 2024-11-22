using APITestProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace APITestProject.Repositories
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>();
        private static int _nextId = 1;

        public List<Product> GetAll() => _products;

        public Product GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index != -1)
            {
                _products[index] = product;
            }
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public void Reset()
        {
            _products = new List<Product>();
            _nextId = 1;
        }
    }
}