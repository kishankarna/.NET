using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
namespace BankSoftware.bank
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsr.Text = Session["name"].ToString();
            try
            {
                string CheckingAccountID = accounts.CheckingAccountIDs(Session["custid"].ToString());
                Session["CheckingAccountID"] = CheckingAccountID;
                lblAccounts.Text= "Checking Account <br/>";
                lblAccounts.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)

            {
                lblMsg.Text = "Checking Account is not created yet!! <br/>";
                lblMsg.ForeColor = System.Drawing.Color.Blue;
            }
            try
            {
                string SavingAccountID = accounts.SavingAccountIDs(Session["custid"].ToString());
                Session["SavingAccountID"] = SavingAccountID;
                lblAccounts.Text += "Saving Account <br/>";
                lblAccounts.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)

            {
                lblMsg.Text += "Saving Account is not created yet!! <br/>";
                lblMsg.ForeColor = System.Drawing.Color.Blue;
            }
            try
            {
                string CreditAccountID = accounts.CreditAccountIDs(Session["custid"].ToString());
                Session["CreditAccountID"] = CreditAccountID;
                lblAccounts.Text += "Credit Account <br/>";
                lblAccounts.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)

            {
                lblMsg.Text += "Credit Account is not created yet!! ";
                lblMsg.ForeColor = System.Drawing.Color.Blue;
            }

             

        }
    }
}