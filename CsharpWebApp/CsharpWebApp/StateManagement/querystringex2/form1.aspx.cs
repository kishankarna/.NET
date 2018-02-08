using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.StateManagement.querystringex2
{
    public partial class form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DrpOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtFirst.Text);
            int b = Convert.ToInt32(txtSecond.Text);
            string op = DrpOperator.Text;
            Response.Redirect("form2.aspx?a=" + a + "&b=" + b + "&op=" + op);

        }

      
    }
}