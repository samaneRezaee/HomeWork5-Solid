using HomeWork5.Task3.Base3;
using HomeWork5.Task3.Domain_Model3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Task3.Implementations3
{
    public class ApiProductRepository3: IProductRepository3
    {
        public List<Product3> GetAllProducts()
        {
            Console.WriteLine("--- Fetching data from Web API ---");
            return new List<Product3>
            {
            new Product3 { Id = 10, Name = "API Phone", Price = 800 },
            new Product3 { Id = 11, Name = "API Tablet", Price = 400 }
            };

        }
    }
}
