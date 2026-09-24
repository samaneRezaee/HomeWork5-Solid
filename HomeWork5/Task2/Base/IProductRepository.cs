using HomeWork5.Task2.Domain_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Task2.Base
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
    }
}
