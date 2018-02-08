using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.StateManagement.Session1
{
    public partial class form2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {
                string uname = Session["name"].ToString();
                lblResult.Text = uname;
            }
            else
            {
                lblResult.Text = "Go to Form1 first!!, Warning!!";
            }
        }
    }
}