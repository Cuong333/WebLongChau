using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
    using WebLongChau.Data;

namespace WebLongChau.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        LongChauWebContext db = new LongChauWebContext();
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listProduct = db.Products.ToList();
            return View(listProduct);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ProductDetail(int ProductId)
        {
            var product = db.Products.SingleOrDefault(x => x.ProductId == ProductId);
            var productImage = db.Products.Where(x => x.ProductId == ProductId).ToList();

            ViewBag.ProductImage = productImage;
            return View(product); // Pass the product object instead of ProductId
        }

    }
}
