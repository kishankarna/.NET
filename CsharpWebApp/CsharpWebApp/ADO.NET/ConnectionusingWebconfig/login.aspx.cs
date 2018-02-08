using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace CsharpWebApp.ADO.NET.ConnectionusingWebconfig
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["cskarna"].ToString();

            cn = new SqlConnection(cs);
            cn.Open();
            Response.Write("Connection is established!!");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from login where UserId=@id", cn);
            cmd.Parameters.AddWithValue("@id", txtName.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if (dr[0].ToString() == txtName.Text && dr[1].ToString() == txtPwd.Text)
                { lbl.Text = "Logged in";
                    lbl.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lbl.Text = "Wrong Credentials";
                    lbl.ForeColor = System.Drawing.Color.Red;
                }
            }

        }
    }
}