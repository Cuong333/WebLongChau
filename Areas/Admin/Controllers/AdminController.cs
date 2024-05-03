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
    [Route("admin/")]
    //[Route("admin/Index")]
    public class AdminController : Controller
    {
        LongChauWebContext db = new LongChauWebContext();
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        // List Product
        [Route("ListProduct")]
        public IActionResult ListProduct()
        {
            var listproduct = db.Products.ToList();
            return View(listproduct);
        }
        // Add Product
        [Route("AddProduct")]
        [HttpGet]

        public IActionResult AddProduct()
        {
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
        public IActionResult EditProduct(int productId)
        {
            var product = db.Products.Find(productId);
            if (product == null)
            {
                return RedirectToAction("ListProduct");
            }
            return View(product);
        }

        [Route("EditProduct")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Update(product);
                db.SaveChanges();
                return RedirectToAction("ListProduct");
            }
            return View(product);
        }

        // Delete Product
        [Route("DeleteProduct")]
        [HttpGet]
        public IActionResult DeleteProduct(int productId)
        {
            var product = db.Products.Find(productId);
            if (product == null)
            {
                TempData["Message"] = "Product not found.";
                return RedirectToAction("ListProduct");
            }


            db.Products.Remove(product);
            db.SaveChanges();
            TempData["ConfirmMessage"] = $"Are you sure you want to delete the product '{product.ProductName}'?";
            return RedirectToAction("ListProduct");
        }
        // Manamange account
        [Route("CustomerList")]
        public IActionResult CustomerList()
        {
            var accounts = db.Customers.ToList();

            return View(accounts);
        }

        //Delete account
        [Route("DeleteCustomer")]
        [HttpGet]
        public IActionResult DeleteCustomer(int CustomerId)
        {
            var customer = db.Customers.Find(CustomerId);
            if (customer == null)
            {
                TempData["Message"] = "Customer not found.";
                return RedirectToAction("CustomerList");
            }
            // Remove the customer
            db.Customers.Remove(customer);
            db.SaveChanges();

            // Set confirmation message
            TempData["ConfirmMessage"] = $"Customer '{customer.CustomerId}' has been deleted.";

            // Redirect to the list of customers
            return RedirectToAction("CustomerList");
        }


    }
}
