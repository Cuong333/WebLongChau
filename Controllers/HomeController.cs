using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebLongChau.Models;

namespace WebLongChau.Controllers
{
    public class HomeController : Controller
    {
        NtLongChauContext db = new NtLongChauContext();
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

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
