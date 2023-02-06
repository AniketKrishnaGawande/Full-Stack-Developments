using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProfileManagement.Models;

namespace ProfileManagement.Controllers;

public class adminController : Controller
{
    private readonly ILogger<adminController> _logger;

    public adminController(ILogger<adminController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
