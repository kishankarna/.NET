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
            lblUsr.Text ="Welcome "+ Session["name"].ToString();
            

            try
            {
                string CheckingAccountID = accounts.CheckingAccountIDs(Session["custid"].ToString());
                Session["CheckingAccountID"] = CheckingAccountID;
                lblChk.Text= "Checking Account";
                lblChk.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)

            {
                lblMsg.Text = "Checking Account is not created!! <br/>";
                lblMsg.ForeColor = System.Drawing.Color.Blue;
            }
            try
            {
                string SavingAccountID = accounts.SavingAccountIDs(Session["custid"].ToString());
                Session["SavingAccountID"] = SavingAccountID;
                lblSav.Text = "Saving Account";
                lblSav.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)

            {
                lblMsg.Text += "Saving Account is not created!! <br/>";
                lblMsg.ForeColor = System.Drawing.Color.Blue;
            }
            try
            {
                string CreditAccountID = accounts.CreditAccountIDs(Session["custid"].ToString());
                Session["CreditAccountID"] = CreditAccountID;
                lblCredit.Text = "Credit Account";
                lblCredit.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)

            {
                lblMsg.Text += "Credit Account is not created!! ";
                lblMsg.ForeColor = System.Drawing.Color.Blue;
            }

            if (lblChk.Text != "" && lblCredit.Text != "" && lblSav.Text != "")
            {
                HyperLink8.Visible = false;
            }

        }
    }
}