using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.StateManagement.querystringex2
{
    public partial class form2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Request.QueryString["a"]);
            int b = Convert.ToInt32(Request.QueryString["b"]);       
            string op = Request.QueryString["op"];
            int result = 0 ;

            switch (op)
            {
                case "add":
                    result = a + b;
                    break;
                case "sub":
                    result = a - b;
                    break;
                case "mul":
                    result = a * b;
                    break;
                case "div":
                    result = a / b;
                    break;
            }
            lbl.Text = string.Format("{0} of {1} and {2} is : {3} ", op, a, b, result);
        }
    }
}