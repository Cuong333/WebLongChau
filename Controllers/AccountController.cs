using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WebLongChau.Models;

public class AccountController : Controller
{
    ////private readonly SignInManager<Customer> _signInManager;

    ////public AccountController(SignInManager<Customer> signInManager)
    ////{
    ////    _signInManager = signInManager;
    ////}

    ////[HttpPost]
    ////public async Task<IActionResult> LoginAsync(Customer customer)
    ////{
    ////    if (ModelState.IsValid)
    ////    {
    ////        // Login
    ////        var result = await _signInManager.PasswordSignInAsync(customer.UserName, customer.PassWord, isPersistent: false, lockoutOnFailure: false);

    ////        if (result.Succeeded)
    ////        {
    ////            return RedirectToAction("Index", "Home");
    ////        }
    ////        else
    ////        {
    ////            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
    ////            return View();
    ////        }
    ////    }
    ////    else
    ////    {
    ////        // Model is not valid, return the view with validation errors
    ////        return View();
    //    }

    ////}
        public IActionResult Login(Customer customer)
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View("Index");
        }
    }

