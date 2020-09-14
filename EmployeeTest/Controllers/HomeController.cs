using EmployeeTest.Models;
using EmployeeTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EmployeeTest.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            try
            {
                var employeeClient = new EmployeeClient();
                var employeeReponse = await employeeClient.GetAllEmployees();
                return View(employeeReponse);
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorModel { Message = ex.Message });
            }
            
        }
    }
}