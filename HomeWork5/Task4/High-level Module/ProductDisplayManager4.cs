using HomeWork5.Task4.Base4;
using HomeWork5.Task4.Domain_Model4;


namespace HomeWork5.Task4.High_level_Module
{
    public class ProductDisplayManager4
    {
        private readonly IProductRepository4 _repository4;

        public ProductDisplayManager4(IProductRepository4 repository4)
        {
            _repository4 = repository4;
        }

        public void ShowProducts()
        {
            List<Product4> products = _repository4.GetAllProducts();

            foreach (Product4 product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
