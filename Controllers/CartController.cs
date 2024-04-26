using Microsoft.AspNetCore.Mvc;
using WebLongChau.Data;
using WebLongChau.Models;
using WebLongChau.Helpers;

namespace WebLongChau.Controllers
{
    public class CartController : Controller
    {
        private readonly LongChauWebContext db;

        public CartController(LongChauWebContext context)
        {
            db = context;
        }
        const string Cart_key = "MyCart";
        public List<Cartitem> Cart => HttpContext.Session.Get<List<Cartitem>>(Cart_key) 
            ?? new List<Cartitem>();
        public IActionResult Index()
        {
            return View(Cart);
        }
        public IActionResult AddToCart(int ProductID, int Quantity = 1)
        {
            var Mycart = Cart;
            var item = Mycart.SingleOrDefault(p => p.ProductID == ProductID);
            /*if (item = null)
            {
                var Product = db.Products.SingleOrDefault(p => p.ProductId == ProductID);
                if (Product = null)
                {
                    return NotFound;
                }
            }*/
            return View();
        }
    }
}
