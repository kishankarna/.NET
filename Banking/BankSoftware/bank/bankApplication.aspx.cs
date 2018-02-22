using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace BankSoftware.bank
{
    public partial class bankApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsr.Text = "Current User : " + Session["name"].ToString();

            if (Session["CheckingAccountID"] != null)
            {
                lblCheck.Text = "$" + Convert.ToString(checkingOperation.AccountBalance(Session["CheckingAccountID"].ToString()));

            }
            if (Session["SavingAccountID"] != null)
            {
                lblSaving.Text = "$" + Convert.ToString(checkingOperation.AccountBalance(Session["SavingAccountID"].ToString()));

            }
            if (Session["CreditAccountID"] != null)
            {
                lblCredit.Text = "$" + Convert.ToString(checkingOperation.AccountBalance(Session["CreditAccountID"].ToString()));

            }


            //else {
            //    lblMsg.Text = "Account is not created yet!! ";
            //    lblMsg.ForeColor = Color.Red;

        }

    }

      
    
}