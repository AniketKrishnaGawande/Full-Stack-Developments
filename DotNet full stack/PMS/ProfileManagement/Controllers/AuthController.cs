using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProfileManagement.Models;
using BOL;
using DAL;
namespace ProfileManagement.Controllers;
using BLL;
public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login(string uname, string psw)
    {


        if (Manager.validate(uname, psw) == "user")
        {
            return RedirectToAction("index", "user");
        }
        else if (Manager.validate(uname, psw) == "admin")
        {
            ViewData["admin"] = DBConnector.findOne(uname);
            return RedirectToAction("index", "admin");
        }

        return RedirectToAction("Index", "Home");
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
