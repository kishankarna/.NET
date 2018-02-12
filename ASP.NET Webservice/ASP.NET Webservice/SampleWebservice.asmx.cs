using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ASP.NET_Webservice
{
    /// <summary>
    /// Summary description for SampleWebservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SampleWebservice : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod (Description ="Takes 2 values as a input for calculation and displays the result" )]
        public string calculation(int firstvalue,int secondvalue, string operation) {
            float result = 0;

            switch (operation)
            {
                case "+":
                    result = firstvalue + secondvalue; break;
                case "-":
                    result = firstvalue - secondvalue; break;
                case "*":
                    result = firstvalue * secondvalue; break;
                case "/":
                    result = firstvalue % secondvalue; break;

                default:
                    break;

            }
            return result.ToString();


        }
    }
}
