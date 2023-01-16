using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VehicleSystem.Models;
using BLL;
using BOL;
namespace VehicleSystem.Controllers;

public class VehicleController : Controller
{
    private readonly ILogger<VehicleController> _logger;

    public VehicleController(ILogger<VehicleController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult List()
    {
        List<Vehicle> list = Manager.getAllVehciles();
        ViewData["vehicleData"] = list;
        return View();
    }

    public IActionResult delete(int id)
    {
        Manager.DeleteVehicles(id);

        return Redirect("List");
    }
    [HttpGet]
    public IActionResult AddVehicle()
    {
        return View();
    }
    //[HttpPost]
    public IActionResult AddVehicle(string vid, string vname, string vcmp, string vprice)
    {
        Manager.AddVehicles(int.Parse(vid), vname, vcmp, double.Parse(vprice));
        return RedirectToAction("Index","Home");
    }

    [HttpPost]
    public IActionResult Search(int vid)
    {
        Vehicle veh = Manager.getSearchedVehcile(vid);
        ViewData["vehicle"] = veh;
        return View();
    }

    public IActionResult update(int id)
    {
        Vehicle veh = Manager.getSearchedVehcile(id);
        ViewData["vehicle"] = veh;
        return View();
    }
    [HttpPost]
    public IActionResult update(string vid, string vname, string vcmp, string vprice)
    {
        Manager.UpdateVehicle(int.Parse(vid), vname, vcmp, double.Parse(vprice));
        return RedirectToAction("List");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
