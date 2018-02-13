using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jquery.Controllers
{
    public class WebserviceController : Controller
    {
        // GET: Webservice
        public ActionResult JqueryWebservice()
        {
            return View();
        }
        public ActionResult facebook() {

            return View();
        }

        public ActionResult Weather() {

            return View();
        }

    }
}