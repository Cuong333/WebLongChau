using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebLongChau.Models;
using WebLongChau.Data;
using System.Linq;

public class AccountController : Controller
{
    private readonly LongChauWebContext _context;

    public AccountController(LongChauWebContext context)
    {
        _context = context;
    }
    // Login
    [HttpGet]
    public IActionResult Login()
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
    public IActionResult Login(Customer customer)
    {
        if (HttpContext.Session.GetString("UserName") == null)
        {
            var u = _context.Customers.FirstOrDefault(x => x.UserName.Equals(customer.UserName) && x.PassWord.Equals(customer.PassWord));

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
        return _context.Customers.Any(e => e.UserName == userName);
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
        if (HttpContext.Session.GetString("UserName") == null)
        {
            if (ModelState.IsValid)
            {
                if (!CustomerExists(customer.UserName))
                {
                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                    HttpContext.Session.SetString("UserName", customer.UserName);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "User already exists!");
                    return View(customer);
                }
            }
            else
            {
                return View(customer);
            }
        }
        else
        {
            return RedirectToAction("Index", "Home");
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
