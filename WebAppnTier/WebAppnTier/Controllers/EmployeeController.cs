using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
// Using MVC in 3 tier Acrhitecture
namespace WebAppnTier.Controllers
{
    public class EmployeeController : Controller
    {
        // GET
        public ActionResult Index()     //Displays all the employee data
        {
            EmployeeBusinessLayer employee = new EmployeeBusinessLayer();
            List<Employee> employeesList= employee.Employees.ToList();

            return View(employeesList);
        }

        //Get Employee/EmployeeByDepartment
        public ActionResult EmployeeByDepartment()     //Displays all the employee data by department
        {
            EmployeeBusinessLayer employee = new EmployeeBusinessLayer();

            //This is L-query
            var employeesList = employee.Employees.ToList().GroupBy(x => x.Department_ID)
                                .Select(y => new DepartmentTotal
                                {
                                    Department= y.Key,
                                    Total=y.Count()
                                }).ToList().OrderByDescending(y=>y.Total);
                                

            return View(employeesList);
        }


        [HttpGet]
        [ActionName("Create")]   //goto this "Create"action for this method/action
        public ActionResult Create_Get() {

            return View();
        }

        [HttpPost]
        [ActionName("Create") ]   //goto this "Create"action for this method/action
        public ActionResult Create_Post(Employee emp) //here emp is automatically binded with formcollection
        {

            if (ModelState.IsValid)
            {             
                EmployeeBusinessLayer empBusinessLayer = new EmployeeBusinessLayer();
                empBusinessLayer.AddEmployee(emp);

                //now after addding the employee then redirect page to index action page
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        [ActionName("Edit")]   //goto this "Create"action for this method/action
        public ActionResult Edit_Get(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee empsingle = employeeBusinessLayer.Employees.Single(emp => emp.ID == id);
            return View(empsingle);
        }

        [HttpPost]
        [ActionName("Edit")]   //goto this "Create"action for this method/action
        public ActionResult Edit_Post(Employee emp)  //emp is automatic binded with formcollectoin
        {         
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.EditEmployee(emp);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet ]
        [ActionName("Delete") ]
        public ActionResult Delete_Get(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee empSingle= employeeBusinessLayer.Employees.Single(x => x.ID == id);
            return View(empSingle);

        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_Post(int id)
        {

            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.DeleteEmployee(id);
                return RedirectToAction ("Index");
            }
            return View();
        }

        [HttpGet ]
        public ActionResult Details(int id)
        {
            EmployeeBusinessLayer empDetails = new EmployeeBusinessLayer();
            Employee empSingle= empDetails.Employees.Single(x => x.ID == id);
            return View(empSingle);
           
        }

    }
}