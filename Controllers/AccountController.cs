using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebLongChau.Models;
using WebLongChau.Data;
using System.Linq;
using WebLongChau.Controllers;

public class AccountController : Controller
{

    LongChauWebContext db = new LongChauWebContext();
    private readonly ILogger<AccountController> _logger;
    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }
    // Login
    [HttpGet]
    public IActionResult Login()
    {
        if (!string.IsNullOrEmpty(HttpContext.Session.GetString("UserName")))
        {
            return RedirectToAction("Index", "Home");
        }
        return View();
    }

    [HttpPost]
    public IActionResult Login(Customer customer)
    {
        if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserName")))
        {
            var u = db.Customers.FirstOrDefault(x => x.UserName == customer.UserName && x.PassWord == customer.PassWord);

            if (u != null)
            {
                HttpContext.Session.SetString("UserName", u.UserName);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password");
                return View();
            }
        }
        else
        {
            return RedirectToAction("Index", "Home");
        }
    }


    // Register
    private bool CustomerExists(string userName)
    {
        return db.Customers.Any(e => e.UserName == userName);
    }
    [HttpGet]
    public IActionResult Register()
    {
        if (HttpContext.Session.GetString("UserName") == null)
        {
            return View();
        }
        else
        {
            return RedirectToAction("Index", "Home");
        }
    }
    [HttpPost]
    public IActionResult Register(Customer customer)
    {
        try
        {
            if (ModelState.IsValid)
            {
                if (!CustomerExists(customer.UserName))
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    HttpContext.Session.SetString("UserName", customer.UserName);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Username already exists!");
                }
            }
            return View(customer);
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", "An error occurred while processing your request. Please try again later.");
            return View(customer);
        }
    }

    // LogOut
    [HttpGet]
    public IActionResult Logout()
    {
        HttpContext.Session.Remove("UserName");
        return RedirectToAction("Index", "Home");
    }
}
