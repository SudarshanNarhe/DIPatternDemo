using DIPatternDemo.Models;

namespace DIPatternDemo.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        int AddProduct(Product product);
        int UpdateProduct(Product product);
        int DeleteProduct(int id);
        Product GetProductById(int id);
    }
}
