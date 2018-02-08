using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.StateManagement.Sessoin2
{
    public partial class form2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                string name = Session["user"].ToString();
                lblUser.Text = name;
                lblUser.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblUser.Text = "Please Login first!!  Warning!!";
                lblUser.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}