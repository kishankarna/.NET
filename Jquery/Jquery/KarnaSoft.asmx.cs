using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Jquery
{
    /// <summary>
    /// Summary description for KarnaSoft
    /// </summary>
    [WebService(Namespace = "http://karnaJquery.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class KarnaSoft : System.Web.Services.WebService
    {
        string[] fruits = { "Apple", "Mango", "Banana", "Strawberry" };

        //public List<string> Fruits { get => fruits; set => fruits = value; }

        [WebMethod]
        public string[] Get()
        {
            return fruits;

        }
    }
}
