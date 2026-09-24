using HomeWork5.Task4.Base4;
using HomeWork5.Task4.Domain_Model4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Task4.Implementation4
{
    public class FileProductRepository4 : IProductRepository4
    {
        public List<Product4> GetAllProducts()
        {
            return new List<Product4>
        {
            new Product4 { Id = 100, Name = "File Phone", Price = 800 },
            new Product4 { Id = 101, Name = "File Tablet", Price = 400 }
        };
        }
    }
}
