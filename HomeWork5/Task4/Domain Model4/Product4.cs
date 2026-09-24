using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Task4.Domain_Model4
{
    public class Product4
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | {Name} | Price: {Price}";
        }
    }
}
