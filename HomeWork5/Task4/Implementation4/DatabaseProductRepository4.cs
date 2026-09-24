using HomeWork5.Task4.Base4;
using HomeWork5.Task4.Domain_Model4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Task4.Implementation4
{
    public class DatabaseProductRepository4 : IProductRepository4
    {
        public List<Product4> GetAllProducts()
        {
            return new List<Product4>
        {
            new Product4 { Id = 1, Name = "DB Laptop", Price = 2000 },
            new Product4 { Id = 2, Name = "DB Mouse", Price = 100 }
        };
        }
    }
}
