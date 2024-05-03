using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebLongChau.Data;
using WebLongChau.Models;
using WebLongChau.Helpers;

namespace WebLongChau.Controllers
{
    
    [Route("AddToCart")]
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

        [HttpGet]
        public IActionResult Index()
        {
            return View(Cart);
        }

        [HttpPost]
        public IActionResult AddToCart(int ProductId, int Quantity = 1)
        {
            var Mycart = Cart;
            var item = Mycart.SingleOrDefault(p => p.ProductId == ProductId);
            if (item == null)
            {
                var product = db.Products.SingleOrDefault(p => p.ProductId == ProductId);
                if (product == null)
                {
                    TempData["Message"] = $"Product with code not found{ProductId}";
                    return Redirect("/404");
                }
                item = new Cartitem
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = product.Price ?? 0,
                    ProductIamge = product.ProductIamge ?? string.Empty,
                    Quantity = Quantity
                };
                Mycart.Add(item);
            }
            else
            {
                item.Quantity += Quantity;
            }
            HttpContext.Session.Set(Cart_key, Mycart);
            return RedirectToAction("Index");
        }
    }
}
