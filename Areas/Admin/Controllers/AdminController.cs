using Microsoft.AspNetCore.Mvc;

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

    }
}
