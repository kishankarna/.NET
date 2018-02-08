using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace BankSoftware
{
    public partial class bankApplication : System.Web.UI.Page
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

            lblCheck.Text ="$"+Convert.ToString( checkingOperation.AccountBalance(Session["account"].ToString()));
                
        }

      
    }
}