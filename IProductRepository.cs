using asp_net_core_MVC_1.Models;

namespace asp_net_core_MVC_1
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
