using Microsoft.AspNetCore.Mvc;
namespace EmployeeSystem.Controllers;
using HR;
using DAL;
[ApiController]
[Route("[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly ILogger<EmployeesController> _logger;

    public EmployeesController(ILogger<EmployeesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Employee> GetAllDetails()
    {
        List<Employee> list = DBConnector.GetAllData();
        return list;
    }
[Route("{id}")]
    [HttpGet]
    public ActionResult<Employee> GetEmpDetails(int id)
    {

        Employee emp = DBConnector.GetEmpData(id);
        return emp;
    }

    [HttpPost]
    public IActionResult InsertEmployee(Employee emp)
    {
        bool flag = DBConnector.InsertEmployee(emp);
        if (flag)
        {
            return Ok(new { message = "employee registered" });
        }
        return Ok(new { message = "error" });
    }
[Route("{id}")]
    [HttpDelete]
    public IActionResult deleteEmp(int id)
    {
        bool flag = DBConnector.DeleteEmp(id);
        if (flag)
        {
            return Ok(new { message = "employee deleted" });
        }
        return Ok(new { message = "employee not deleted" });
    }
[Route("{id}")]
    [HttpPut]
    public IActionResult UpdateEmp(int id, Employee emp)
    {

        bool flag = DBConnector.UpdateEmp(id, emp);
        if (flag)
        {
            return Ok(new { message = "employee details updated" });
        }
        return Ok(new { message = "employee details not updated" });
    }





}
