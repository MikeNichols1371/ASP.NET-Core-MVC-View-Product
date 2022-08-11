using ASP.NET_Core_MVC_View_Product.Models;
using Testing.Models;

namespace ASP.NET_Core_MVC_View_Product
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
    }
}
