using Microsoft.AspNetCore.Mvc;
using WebLongChau.Models;
namespace WebLongChau.Areas.Admin.Controllers
{

    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class AdminController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult ListProduct()
        //{
        //    var listproduct =db
        //}
    }
}
