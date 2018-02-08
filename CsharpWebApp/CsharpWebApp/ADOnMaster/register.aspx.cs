using System;
using System.Data.SqlClient;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ADOnMaster
{
    public partial class register : System.Web.UI.Page
    {
        string cs = "server=Nikson-PC\\SQLEXPRESS; user id=sa; password=1k2k3k4k5k6k; database=hotel";
        SqlConnection cn = null;

        string query = string.Empty;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            Response.Write("Database connection successfull!!");


        }
        void ClearText()
        {
            txtPss.Text = txtRenterPss.Text = txtUsr.Text = string.Empty;
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {

            if (txtUsr.Text != string.Empty && txtPss.Text != string.Empty)
            {


                if (txtPss.Text == txtRenterPss.Text)
                {
                    if (chkTerms.Checked) {
                        query = "insert into Login values(@id,@password)";
                        cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@id", txtUsr.Text);
                        cmd.Parameters.AddWithValue("@password", txtPss.Text);
                        cmd.ExecuteNonQuery();
                        lblDisp.Text = "User creation successfull!!, Congratulation!!";
                        lblDisp.ForeColor = System.Drawing.Color.Green;
                       // Response.Redirect("log.aspx");
                        ClearText();
                    }
                    else {
                        lblDisp.Text = "Please Accept the Terms and conditions!!";
                        lblDisp.ForeColor = System.Drawing.Color.Red;

                    }
                }

                else
                {
                    lblDisp.Text = "Password does not match, try again!!";
                    lblDisp.ForeColor = System.Drawing.Color.Red;
                    ClearText();
                }
            }
            else
            {
                lblDisp.Text = "Enter the required informations!!";
                lblDisp.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnLog_Click(object sender, EventArgs e)
        {
            Response.Redirect("log.aspx");
        }
    }
}