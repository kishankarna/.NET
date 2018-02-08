using System;
using System.Data.SqlClient;
using System.Data;

using System.Web.UI.WebControls;

namespace CsharpWebApp.ADOnMaster
{
    public partial class log : System.Web.UI.Page
    {
        string cs = "server=Nikson-PC\\SQLEXPRESS; user id=sa; password=1k2k3k4k5k6k; database=hotel";
        SqlConnection cn = null;

        string query = string.Empty;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            Response.Write("Database connection successfull!!");
        }
         void Clear() {

            txtPass.Text = txtUser.Text = string.Empty;
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select * from Login where id=@id";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", txtUser.Text);
            
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == txtUser.Text && dr[1].ToString() == txtPass.Text)
                {
                    Response.Redirect("home.aspx");

                }
                else
                {
                    lbl.Text = "Login Credentials is wrong!!"; lbl.ForeColor = System.Drawing.Color.Red; Clear();
                }
            }
            else { lbl.Text = "There is no such User Name!!"; lbl.ForeColor = System.Drawing.Color.Red; Clear(); }
          
           
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}