using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DVD_RENTAL.Models;

namespace DVD_RENTAL.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Details()
        {
            CustomerContext Cusdb = new CustomerContext();
            IEnumerable <Customer> customer=Cusdb.GetEmployees.ToList();  //getting all customers
     
            
            return View(customer);
        }
    }
}