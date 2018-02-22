using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Data;

namespace BankSoftware.bank
{
    public partial class saving : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {


            if (Session["SavingAccountID"] != null)
            {
                lblUsr.Text = "Current User : " + Session["name"].ToString();
                lblUsr.ForeColor = Color.Green;


                DataSet ds = new DataSet();
                lblCheck.Text = Convert.ToString(checkingOperation.AccountBalance(Session["SavingAccountID"].ToString()));

                string acc = Session["SavingAccountID"].ToString();
                //dt = checkingOperation.GetTransactions(Session["account"].ToString());
                ds.Tables.Add(checkingOperation.GetTransactions(acc));
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            else
            {
                lblMsg.Text = "Create Saving Account!!";
                lblMsg.ForeColor = Color.Red;
            }
        }
    }
}