using System;
using System.Collections.Generic;
using BusinessLayer;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Data;
namespace BankSoftware.bank
{
    public partial class Credit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CreditAccountID"] != null)
            {
                lblUsr.Text = "Current User : " + Session["name"].ToString();
                lblUsr.ForeColor = Color.Green;


                DataSet ds = new DataSet();
                lblCheck.Text = Convert.ToString(checkingOperation.AccountBalance(Session["creditAccountID"].ToString()));

                string acc = Session["creditAccountID"].ToString();
                //dt = checkingOperation.GetTransactions(Session["account"].ToString());
                ds.Tables.Add(checkingOperation.GetTransactions(acc));
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                lbl.Text = "Credit Limit : $500.00";
            }
            else
            {
                lblMsg.Text = "Create Credit Account!!";
                lblMsg.ForeColor = Color.Red;
            }
        }
    }
}