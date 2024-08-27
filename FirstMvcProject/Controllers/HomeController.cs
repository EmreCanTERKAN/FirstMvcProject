using FirstMvcProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMvcProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Detail()
        {
            ProductViewModel product = new ProductViewModel();
            product.Product = new Product
            {
                Id = 1,
                Name = "Test", 
                Price = 100


            };
            product.Review = new List<string> { "Yorum 1" };
            product.IsInStock = true;

            return View(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(product);

        }


    }
}
