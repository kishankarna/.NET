using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.Navigation
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPass.Text != "")
                if (txtName.Text == "karna" && txtPass.Text == "niksonbaby")
                    Response.Redirect("Home.aspx");
                else
                {
                    lbl.Text = "Invalid Credential!!";
                    lbl.ForeColor = System.Drawing.Color.Red;
                }
            else { lbl.Text = "Please provide login info!!"; lbl.ForeColor = System.Drawing.Color.Red; }
        }
    }
}