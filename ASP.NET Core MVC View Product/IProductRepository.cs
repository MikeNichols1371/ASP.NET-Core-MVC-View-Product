using ASP.NET_Core_MVC_View_Product.Models;

namespace ASP.NET_Core_MVC_View_Product
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
    }
}
