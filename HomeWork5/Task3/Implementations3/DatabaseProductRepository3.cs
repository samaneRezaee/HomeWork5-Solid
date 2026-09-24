
using HomeWork5.Task3.Base3;
using HomeWork5.Task3.Domain_Model3;


namespace HomeWork5.Task3.Implementations3
{
    public class DatabaseProductRepository3 : IProductRepository3
    {
        public List<Product3> GetAllProducts() 
        {
            Console.WriteLine("--Fetching data from Database --");
            return new List<Product3>()
            {
                new Product3 { Id = 1, Name = "DB Laptop", Price = 2000},
                new Product3 { Id = 2, Name = "DB Mouse", Price = 100}
            };
        }
    }
}
