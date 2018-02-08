using System;
using System.Collections.Generic;
using System.Data;
using BusinessLayer;
using System.Drawing;
using System.Web.UI.WebControls;

namespace BankSoftware
{
    public partial class checking : System.Web.UI.Page
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

            DataSet ds = new DataSet();
            lblCheck.Text = Convert.ToString(checkingOperation.AccountBalance(Session["account"].ToString()));

            string acc = Session["account"].ToString();
            //dt = checkingOperation.GetTransactions(Session["account"].ToString());
            ds.Tables.Add(checkingOperation.GetTransactions(acc));
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}