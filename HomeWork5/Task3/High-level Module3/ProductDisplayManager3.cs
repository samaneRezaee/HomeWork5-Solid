using HomeWork5.Task3.Base3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Task3.High_level_Module3
{
    public class ProductDisplayManager3
    {
        private readonly IProductRepository3 _repository;

        // دقت کن: اینجا هنوز از اینترفیس استفاده می‌کنیم (DIP رعایت شده)
        public ProductDisplayManager3(IProductRepository3 repository)
        {
            _repository = repository;
        }

        public void ShowProducts()
        {
            Console.WriteLine($"--- Starting Display Process ---");
            var products = _repository.GetAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("--------------------------------\n");
        }
    }
}
