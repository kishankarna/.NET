using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;
namespace CsharpWebApp.security.FormSecurity
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            string cs= "server=Nikson-PC\\SQLEXPRESS; user id=sa; password=1k2k3k4k5k6k; database=securitypractice";

            using (SqlConnection cn = new SqlConnection(cs))
            {
                cn.Open();

                Response.Write("Connection established!!");

                string query = "insert into [login] values(@name,@password)";
                SqlCommand cmd = new SqlCommand(query, cn);

                string encrypt = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPwd.Text, "SHA1");
                cmd.Parameters.AddWithValue("@name", txtUsr.Text);
                cmd.Parameters.AddWithValue("Password", encrypt);
                cmd.ExecuteNonQuery();
                cn.Close();
                Response.Redirect("~security/FormSecurity/login.aspx");
            }
        }
    }
}