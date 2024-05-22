using DIPatternDemo.Data;
using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;

        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddProduct(Product product)
        {
            int result = 0;
            db.Products.Add(product);
           result = db.SaveChanges();
            return result;
        }

        public int DeleteProduct(int id)
        {
            int result = 0;
           var model = db.Products.Where(p => p.ProductId== id).FirstOrDefault();
            if(model != null)
            {
                db.Products.Remove(model);
                result = db.SaveChanges();
                return result;
            }
            return result;
        }

        public Product GetProductById(int id)
        {
            var product = db.Products.FirstOrDefault(p => p.ProductId == id);
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public int UpdateProduct(Product product)
        {
            int result = 0;
            var prd = db.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (prd != null)
            {
                prd.ProductName = product.ProductName;
                prd.Price = product.Price;
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
