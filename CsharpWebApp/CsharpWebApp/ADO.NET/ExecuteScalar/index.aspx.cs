using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace CsharpWebApp.ADO.NET.ScalarExecute
{
    public partial class index : System.Web.UI.Page
    {
        string cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k ;database=hotel";
        SqlConnection cn = null;

        string query = string.Empty;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            Label1.Text = "Connection established!!";
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            query = "select Name from cust where id =@id";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            string dr = cmd.ExecuteScalar().ToString();
            lblResult.Text = dr;
        }
    }
}