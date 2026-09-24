using HomeWork5.Task2.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Task2.High_level_Module
{
    public class ProductDisplayManager
    {
        private readonly IProductRepository _repository;

        public ProductDisplayManager(IProductRepository repository)
        {
            _repository = repository;
        }

        public void ShowProducts()
        {
            var products = _repository.GetAllProducts();
            Console.WriteLine("Displaying Product List:");
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
            Console.WriteLine();
        }
    }
}
