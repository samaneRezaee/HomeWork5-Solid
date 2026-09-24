using HomeWork5.Task2.Base;
using HomeWork5.Task2.Domain_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Task2.Implementations
{
    public class ApiProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            Console.WriteLine("--- Fetching data from Web API ---");
            return new List<Product>
            {
            new Product { Id = 10, Name = "API Phone", Price = 800 },
            new Product { Id = 11, Name = "API Tablet", Price = 400 }
            };
        
        }

    }
}
