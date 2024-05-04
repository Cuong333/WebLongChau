using Microsoft.AspNetCore.Mvc;
using WebLongChau.Helpers;
using WebLongChau.Models;
using WebLongChau.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerceMVC.Controllers
{
    public class CartController : Controller
    {
        private readonly LongChauWebContext db;

        public CartController(LongChauWebContext context)
        {
            db = context;
        }
        const string CART_KEY = "MYCART";
        public List<Cartitem> Cart => HttpContext.Session.Get<List<Cartitem>>(CART_KEY) ?? new List<Cartitem>();
        // View cart
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddToCart(int ProductId, int quantity = 1)
        {
            var cart = Cart;
            var item = cart.FirstOrDefault(p => p.ProductId == ProductId);
            if (item == null)
            {
                var product = db.Products.FirstOrDefault(p => p.ProductId == ProductId);
                if (product == null)
                {
                    return View(cart); 
                }
                item = new Cartitem
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = product.Price ?? 0,
                    ProductIamge = product.ProductIamge ?? string.Empty,
                    Quantity = quantity
                };
                cart.Add(item);
            }
            else
            {
                item.Quantity += quantity; 
            }

            HttpContext.Session.Set(CART_KEY, cart); 

            return RedirectToAction("AddToCart"); 
        }


        // Remove cart
        public IActionResult RemoveCart(int ProductId)
        {
            var cart = Cart;
            var item = cart.SingleOrDefault(p => p.ProductId == ProductId);
            if (item != null)
            {
                cart.Remove(item);
                HttpContext.Session.Set(CART_KEY, cart);
            }
            return RedirectToAction("AddToCart");
        }
    }
}