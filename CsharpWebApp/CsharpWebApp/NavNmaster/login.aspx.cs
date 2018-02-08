using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.NavNmaster
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btbLog_Click(object sender, EventArgs e)
        {
            if (txtUsr.Text == "karna" && txtPss.Text == "niksonbaby")
                Response.Redirect("Curriculumn.aspx");
            else {
                lblMsg.Text = "Not Valid Credentials!!";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}