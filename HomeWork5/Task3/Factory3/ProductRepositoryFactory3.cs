using HomeWork5.Task3.Base3;
using HomeWork5.Task3.Implementations3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.Task3.Factory3
{
    public class ProductRepositoryFactory3
    {
        public IProductRepository3 CreateRepository(DataSourceType3 type)
        {
            switch (type)
            {
                case DataSourceType3.Database:
                    return new DatabaseProductRepository3();

                case DataSourceType3.Api:
                    return new ApiProductRepository3();

                case DataSourceType3.File:
                    return new FileProductRepository3();

                default:
                    throw new ArgumentException("نوع منبع داده نامعتبر است!");
            }
        }
    }
}
