using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebLongChau.Data;
using WebLongChau.Models;
namespace WebLongChau.Areas.Admin.Controllers
{

    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class AdminController : Controller
    {
        NtLongChauContext db=new NtLongChauContext();
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        // List Product
        [Route("ListProduct")]
        public IActionResult ListProduct()
        {
         var listproduct =db.Products.ToList();
          return View(listproduct);
        }
        // Add Product
        [Route("AddProduct")]
        [HttpGet]

        public IActionResult AddProduct()
        {
            ViewBag.SupplierId = new SelectList (db.Suppliers.ToList(), "SupplierId", "SupplierName");
            ViewBag.CategoryId = new SelectList (db.Categories.ToList(), "CategoryId", "Name");
            return View();
        }
        [Route("AddProduct")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProduct(Product product) 
        {
            if (ModelState.IsValid != null)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("ListProduct");   
            }
            return View(product);
        }

        // Edit Product
        [Route("EditProduct")]
        [HttpGet]
        public IActionResult EditProduct(int ProductId)
        {
            ViewBag.SupplierId = new SelectList(db.Suppliers.ToList(), "SupplierId", "SupplierName");
            ViewBag.CategoryId = new SelectList(db.Categories.ToList(), "CategoryId", "Name");
            var product = db.Products.Find(ProductId);
            return View(product);
        }
        [Route("EditProduct")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ListProduct","HomeAdmin");
            }
            return View(product);
        }
        // Delete Product
        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProduct(int productId)
        {
            TempData["Message"] = "";
            var product = db.Products.Find(productId);
            if (product == null)
            {
                TempData["Message"] = "Can not delete product";
                return NotFound();
            }

            db.Products.Remove(product);
            db.SaveChanges();
            TempData["Message"] = "Delete product successfull";
            return RedirectToAction("ListProduct", "HomeAdmin");
        }

    }
}
