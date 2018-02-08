using System;
using System.Drawing;
using System.Data.SqlClient;

namespace CsharpWebApp.StateManagement.Session3
{
    public partial class form1 : System.Web.UI.Page
    {
        string cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=apartment";
        SqlConnection cn = null;

        string query = string.Empty;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            Response.Write("Connection to database established!!");
         
        }

        protected void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select Password from login where UserID=@userid";
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@userid", txtName.Text);

                string pss = cmd.ExecuteScalar().ToString();

                if (pss != null)
                {
                    if (pss == txtPwd.Text)
                    {
                        Session["user"] = txtName.Text;
                       
                        Response.Redirect("home.aspx");

                    }
                    else if (txtPwd.Text == string.Empty) { lbl.Text = "Please Enter Password!!";lbl.ForeColor = Color.Red; }
                    else { lbl.Text = "Wrong Password!!"; lbl.ForeColor = Color.Red; }
                }

            }
            catch (Exception ex) { lbl.Text = "Wrong Credentials!!";lbl.ForeColor = Color.Red; }
        }

      
    }
}