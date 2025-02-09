using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace BTK_Practice
{
    public class ProductService
    {
        private readonly string dummyData;
        public ProductService()
        {
            dummyData = System.IO.File.ReadAllText("C:\\BTK_Practice\\BTK_Practice\\Products.json");
        }


        public List<Product> GetProducts()
        {
            var products = JsonConvert.DeserializeObject<ProductWrapper>(dummyData);
            return products.Products;
        }


    }
}
