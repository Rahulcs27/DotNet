using Demo_codeFirstApproach.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo_codeFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WareHouseDbContext context = new WareHouseDbContext();

            Product product = new Product
            {
                Name = "Mobile",
                Price = 1000.56M,
                CategoryId = 1
            };
            
            context.Products.Add(product);
            Category category = new Category
            {
                Name = "Electronics"
            };
            context.Categories.Add(category);
            context.SaveChanges();
            //var products = context.Products.Include(p => p.Category).ToList();

            foreach (var p in context.Products)
            {
                Console.WriteLine($"Name :: {p.Name} Price:: {p.Price} Category Id::{p.CategoryId}");
            }
        }
    }
}
