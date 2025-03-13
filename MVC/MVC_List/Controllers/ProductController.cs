using Microsoft.AspNetCore.Mvc;
using MVC_List.Models;
using MVC_List.Repository;

namespace MVC_List.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult GetProducts()
        {
            List<Product> products = _productRepository.GetProducts();
            return View(products);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            _productRepository.AddProduct(product);
            return RedirectToAction("GetProducts");
        }
        public IActionResult RemoveProduct(int id, string name)
        {
            Product prod = new Product() { Id = id, Name = name };
            return View(prod);
        }
        [HttpPost]
        public IActionResult RemoveProduct(int id)
        {
            _productRepository.RemoveProduct(id);
            return RedirectToAction("GetProducts");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var product = _productRepository.GetProducts().FirstOrDefault(p => p.Id == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            _productRepository.UpdateProduct(product);
            return RedirectToAction("GetProducts");
        }

    }
}
