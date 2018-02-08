using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;
using System.Drawing;
using System.Web.UI.WebControls;

namespace BankSoftware
{
    public partial class saving : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
       

            if (Session["name"] != null)
            {
                lblUsr.Text = "Current User : " + Session["name"].ToString();
                lblUsr.ForeColor = Color.Green;
            }
            else
            {
                lblUsr.Text = "Please Log in First!!";
                lblUsr.ForeColor = Color.Red;
            }
            // lblCheck.Text = Convert.ToString(checkingOperation.AccountBalance(Session["account"].ToString()));
        }
    }
}