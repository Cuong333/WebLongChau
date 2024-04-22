//using Microsoft.AspNetCore.Mvc;
//using WebLongChau.Data;

//namespace WebLongChau.Controllers
//{
//    public class AccessController : Controller
//    {
//        NtLongChauContext db = new NtLongChauContext();


//        [HttpGet]
//        public IActionResult Login()
//        {
//            if (HttpContext.Session.GetString("UserName") == null)
//            {
//                return View();
//            }
//           else
//            {
//                return RedirectToAction("Index");
//            }
//        }
      
       
//    }
//}
