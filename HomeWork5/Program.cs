using HomeWork5.Task2.Base;
using HomeWork5.Task2.High_level_Module;
using HomeWork5.Task2.Implementations;

namespace HomeWork5
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Test task2-----------------------");
            // for DB
            IProductRepository dbRepo = new DatabaseProductRepository();
            ProductDisplayManager managerWithDb = new ProductDisplayManager(dbRepo);
            managerWithDb.ShowProducts();

            // for Api
            IProductRepository apiRepo = new ApiProductRepository();
            ProductDisplayManager managerWithApi = new ProductDisplayManager(apiRepo);
            managerWithApi.ShowProducts();

            // for File
            IProductRepository fileRepo = new FileProductRepository();
            ProductDisplayManager managerWithFile = new ProductDisplayManager(fileRepo);
            managerWithFile.ShowProducts();
        }
    }
}
