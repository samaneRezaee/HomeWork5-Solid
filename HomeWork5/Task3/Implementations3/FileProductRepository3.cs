using HomeWork5.Task3.Domain_Model3;
using HomeWork5.Task3.Base3;


namespace HomeWork5.Task3.Implementations3
{
    public class FileProductRepository3 : IProductRepository3
    {
        public List<Product3> GetAllProducts()
        {
            Console.WriteLine("--- Fetching data from File ---");
            return new List<Product3>
            {
            new Product3 { Id = 10, Name = "File Phone", Price = 800 },
            new Product3 { Id = 11, Name = "File Tablet", Price = 400 }
            };

        }
    }
}
