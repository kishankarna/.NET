using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.Security;
namespace CsharpWebApp.security.FormSecurity
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLog_Click(object sender, EventArgs e)
        {
            string pass = string.Empty ;
            string cs = "server=Nikson-PC\\SQLEXPRESS; user id=sa; password=1k2k3k4k5k6k; database=securitypractice";

            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();

                Response.Write("Connection established!!");

                string query = "select * from [login] where name=@name";
                SqlCommand cmd = new SqlCommand(query, cn);

//                string encrypt = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPwd.Text, "SHA1");
                cmd.Parameters.AddWithValue("@name", txtUsr.Text);
                SqlDataReader dr= cmd.ExecuteReader();
                if(dr.Read())
                    pass = dr[1].ToString();
                cn.Close();
            }

            string pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPwd.Text,"SHA1");
            if (pwd==pass)
            {
               FormsAuthentication.RedirectFromLoginPage(txtUsr.Text, CheckBox1.Checked);
                //FormsAuthentication.RedirectFromLoginPage(txtUsr.Text, false);

            }
            else {
                Label1.Text = "Invalid credential!!";
            }
        }
    }
}