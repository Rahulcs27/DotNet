using MVC_List.Models;

namespace MVC_List.Repository
{
    public class ProductRepository : IProductRepository
    {
        List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>()
            {
                new Product() {Id = 1 , Name ="Laptop" }
            };
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public void AddProduct(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
        }
        public void RemoveProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
        public void UpdateProduct(Product product)
        {
            var productToUpdate = products.FirstOrDefault(p => p.Id == product.Id);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
            }
        }
    }
}
