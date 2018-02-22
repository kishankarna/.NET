using System;
using System.Collections.Generic;
using System.Data;
using BusinessLayer;
using System.Drawing;
using System.Web.UI.WebControls;

namespace BankSoftware.bank
{
    public partial class checking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (Session["CheckingAccountID"] != null)
            {
                lblUsr.Text = "Current User : " + Session["name"].ToString();
                lblUsr.ForeColor = Color.Green;
          

            DataSet ds = new DataSet();
            lblCheck.Text = Convert.ToString(checkingOperation.AccountBalance(Session["CheckingAccountID"].ToString()));

            string acc = Session["CheckingAccountID"].ToString();
            //dt = checkingOperation.GetTransactions(Session["account"].ToString());
            ds.Tables.Add(checkingOperation.GetTransactions(acc));
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            }
            else
            {
                lblMsg.Text = "Create Checking Account!!";
                lblMsg.ForeColor = Color.Red;
            }
        }
    }
}