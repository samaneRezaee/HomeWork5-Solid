using HomeWork5.Task2.Base;
using HomeWork5.Task2.High_level_Module;
using HomeWork5.Task2.Implementations;
using HomeWork5.Task3.Base3;
using HomeWork5.Task3.Factory3;
using HomeWork5.Task3.High_level_Module3;

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

            // ۲. فرض کنیم این مقدار از یک فایل Config یا ورودی کاربر می‌آید
            Console.WriteLine("Please select source (1: DB, 2: API, 3: File): ");
            string input = Console.ReadLine();

            DataSourceType3 selectedType = input switch
            {
                "1" => DataSourceType3.Database,
                "2" => DataSourceType3.Api,
                "3" => DataSourceType3.File,
                _ => DataSourceType3.Database // پیش‌فرض
            };

            // ۳. استفاده از Factory برای ساخت Repository
            // کلاس اصلی اصلاً نمی‌داند چطور ساخته شده‌اند، فقط آن‌ها را دریافت می‌کند
            IProductRepository3 repository3 = factory3.CreateRepository(selectedType);

            // ۴. اجرای نمایش
            ProductDisplayManager3 manager = new ProductDisplayManager3(repository3);
            manager.ShowProducts();
        }
    }
}
