using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProfileManagement.Models;
using DAL;
namespace ProfileManagement.Controllers;

public class userController : Controller
{
    private readonly ILogger<userController> _logger;

    public userController(ILogger<userController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
                    ViewData["user"] = DBConnector.getAllDetails();
                    return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
