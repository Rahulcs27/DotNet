using MVC_List.Models;

namespace MVC_List.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        void AddProduct(Product product);
        void RemoveProduct(int id);
        void UpdateProduct(Product product);
    }
}
