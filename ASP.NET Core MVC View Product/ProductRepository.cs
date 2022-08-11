using ASP.NET_Core_MVC_View_Product.Models;
using Dapper;
using System.Data;

namespace ASP.NET_Core_MVC_View_Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}
