using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
namespace WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee Initial page List the employees
       // [Route("Employee/Index")]
        public ActionResult Index(int id) {

            EmployeeContext empDetail = new EmployeeContext();
            List<Employee> lstemp = empDetail.GetEmployees.Where(emp=>emp.Department_ID==id).ToList();
            return View(lstemp);
        }

        //GET : Employee/Details/1?
        public ActionResult Details(int id)
        {
            EmployeeContext empContext = new EmployeeContext();
            Employee emp1= empContext.GetEmployees.Single(emp => emp.ID==id);

            return View(emp1);
        }
       
    }
}