using demo_databaseFirstApproach.Models;
using Microsoft.EntityFrameworkCore;

namespace demo_databaseFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SHopDBContext())
            {
                // Insert Data
                var category = new Category { Name = "Electronics" };
                context.Categories.Add(category);
                context.SaveChanges();

                var product = new Product { Name = "Laptop", Price = 1500, CategoryId = category.Id };
                context.Products.Add(product);
                context.SaveChanges();

                // Retrieve Data
                var products = context.Products.Include(p => p.Category).ToList();
                foreach (var p in products)
                {
                    Console.WriteLine($"{p.Name} - {p.Category.Name} - {p.Price}");
                }
            }
        }
    }
}
