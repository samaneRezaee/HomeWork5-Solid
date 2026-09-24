using HomeWork5.Task2.Base;
using HomeWork5.Task2.Domain_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Task2.Implementations
{
    public class DatabaseProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            Console.WriteLine("--Fetching data from Database --");
            return new List<Product>()
            {
                new Product { Id = 1, Name = "DB Laptop", Price = 2000},
                new Product { Id = 2, Name = "DB Mouse", Price = 100}
            };
        }
    }
}
