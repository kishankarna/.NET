using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Security.Cryptography;
using System.Configuration;
using System.Data.SqlClient;

namespace CsharpWebApp.loginWithHash
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection cn = null;
        SqlCommand cmd= null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["cskarna"].ToString();
            cn = new SqlConnection(cs);
            cn.Open();
            Response.Write("Connection Established!!");
        }

        protected void BtnLog_Click(object sender, EventArgs e)
        {
            //md5 hashing   //ram has ram1 password
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


            cmd = new SqlCommand("Select * from login where UserId=@id", cn);
            cmd.Parameters.AddWithValue("@id", TxtUsr.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if (dr[0].ToString() == TxtUsr.Text && dr[1].ToString() == hash_pass)
                {

                    Session["name"] = TxtUsr.Text;
                    lbl.Text = "Logged in";
                    lbl.ForeColor = System.Drawing.Color.Green;
                    Response.Redirect("home.aspx");
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