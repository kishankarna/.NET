using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
namespace WebApp.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            EmployeeContext empployeeContext = new EmployeeContext();
            List<Department> lstdepartment= empployeeContext.GetDepartment.ToList();
            return View(lstdepartment);
        }


      
    }
}