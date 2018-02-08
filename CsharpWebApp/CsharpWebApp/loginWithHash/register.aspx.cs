using System;
using System.Security.Cryptography;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace CsharpWebApp.loginWithHash
{

    public partial class register : System.Web.UI.Page
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["cskarna"].ToString();
            cn = new SqlConnection(cs);
            cn.Open();
            Response.Write("Connection Established!!");



        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TxtUsr.Text == "" && TxtPwd.Text == "" && TxtRPwd.Text == "")
            {
                lbl.Text = "Please Fill all the records!!, Warning!!";
                lbl.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (TxtPwd.Text ==TxtRPwd.Text && TxtPwd.Text!=null && TxtRPwd.Text!=null)
                {
                    //md5 hashing
                    byte[] hs = new byte[50];
                    string pass = TxtPwd.Text;
                    MD5 md5 = MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
                    byte[] hash = md5.ComputeHash(inputBytes);
                    StringBuilder sb = new StringBuilder();
                    for (int cnt = 0; cnt < hash.Length; cnt++)
                    {
                        hs[cnt] = hash[cnt];
                        sb.Append(hs[cnt].ToString("x2"));

                    }
                    var hash_pass = sb.ToString();

                    string query = "insert into login values(@UserID,@Password)";
                    cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@UserID", TxtUsr.Text);
                    cmd.Parameters.AddWithValue("@Password", hash_pass );
                    int i=cmd.ExecuteNonQuery();
                    lbl.Text = i+ "User Created!! Successfull!!";
                    lbl.ForeColor = System.Drawing.Color.Green;
                    cmd.Dispose();
                }
            }
        }
    }
}