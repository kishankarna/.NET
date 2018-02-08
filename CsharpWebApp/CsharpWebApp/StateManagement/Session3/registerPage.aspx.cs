using System;
using System.Data.SqlClient;
using System.Drawing;

namespace CsharpWebApp.StateManagement.Session3
{
    public partial class registerPage : System.Web.UI.Page
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPwd.Text == txtRePwd.Text)
                {
                    query = "insert into login values(@usr, @pwd)";
                    cmd = new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue("@usr", txtName.Text);
                    cmd.Parameters.AddWithValue("@pwd", txtPwd.Text);
                    string rPss = txtRePwd.Text;

                    cmd.ExecuteNonQuery();
                    lblResult.Text = "Succesfull creatoin, Congratulations!!"; lblResult.ForeColor = Color.Green;
                    txtName.Text = txtPwd.Text = txtRePwd.Text = string.Empty;
                }
                else
                {
                    lblResult.Text = "Password not Matched!!";
                    lblResult.ForeColor = Color.Red;
                }
            }
            catch (SqlException ex) { lblResult.Text = "user name already exist!! Error"; lblResult.ForeColor = Color.Red; }
        }
    }
}