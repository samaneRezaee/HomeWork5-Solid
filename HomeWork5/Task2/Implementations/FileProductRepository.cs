using HomeWork5.Task2.Base;
using HomeWork5.Task2.Domain_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Task2.Implementations
{
    public class FileProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            Console.WriteLine("--- Fetching data from File ---");
            return new List<Product>
            {
            new Product { Id = 10, Name = "File Phone", Price = 800 },
            new Product { Id = 11, Name = "File Tablet", Price = 400 }
            };

        }
    }
}
