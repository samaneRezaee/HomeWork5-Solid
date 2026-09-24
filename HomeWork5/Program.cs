using HomeWork5.Task2.Base;
using HomeWork5.Task2.High_level_Module;
using HomeWork5.Task2.Implementations;
using HomeWork5.Task3.Base3;
using HomeWork5.Task3.Factory3;
using HomeWork5.Task3.High_level_Module3;
using HomeWork5.Task4.Base4;
using HomeWork5.Task4.High_level_Module;
using HomeWork5.Task4.Implementation4;
using Microsoft.Extensions.DependencyInjection;

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

            Console.WriteLine("==========================================");

            //task3
            Console.WriteLine("Test task3-----------------------");

            var factory3 = new ProductRepositoryFactory3();

            Console.WriteLine("Please select source (1: DB, 2: API, 3: File): ");
            string input3 = Console.ReadLine();

            DataSourceType3 selectedType;

            switch (input3)
            {
                case "1":
                    selectedType = DataSourceType3.Database;
                    break;

                case "2":
                    selectedType = DataSourceType3.Api;
                    break;

                case "3":
                    selectedType = DataSourceType3.File;
                    break;

                default:
                    selectedType = DataSourceType3.Database;
                    break;
            }

            IProductRepository3 repository3 = factory3.CreateRepository(selectedType);

            ProductDisplayManager3 manager = new ProductDisplayManager3(repository3);
            manager.ShowProducts();
            Console.WriteLine("==========================================");
            Console.WriteLine();


            //task4
            Console.WriteLine("Test task4-----------------------");

            Console.WriteLine("Choose Data type:");
            Console.WriteLine("1. Database");
            Console.WriteLine("2. API");
            Console.WriteLine("3. File");

            string? input4 = Console.ReadLine();

            var services = new ServiceCollection();

            switch (input4)
            {
                case "1":
                    services.AddTransient<IProductRepository4, DatabaseProductRepository4 >();
                    break;

                case "2":
                    services.AddTransient<IProductRepository4, ApiProductRepository4>();
                    break;

                case "3":
                    services.AddTransient<IProductRepository4, FileProductRepository4>();
                    break;

                default:
                    Console.WriteLine("invalid choice.");
                    return;
            }

            services.AddTransient<ProductDisplayManager4>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                ProductDisplayManager4 manager4 =
                    serviceProvider.GetRequiredService<ProductDisplayManager4>();

                manager4.ShowProducts();
            }
        }
    }
}
    

