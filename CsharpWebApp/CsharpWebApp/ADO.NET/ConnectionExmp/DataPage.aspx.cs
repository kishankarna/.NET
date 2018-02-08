using System;
using System.Data.SqlClient;

namespace CsharpWebApp.ADO.NET.ConnectionExmp
{
    public partial class DataPage : System.Web.UI.Page
    {
        string cs = string.Empty;
        string query = string.Empty;

        SqlConnection cn = null;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = " server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k;database=hotel";
            cn = new SqlConnection(cs);
            cn.Open();
            lblDsply.Text = "Connection succesfull";
        }

        protected void btnDsply_Click(object sender, EventArgs e)
        {
            query = "select * from Customer";
            cmd = new SqlCommand(query, cn);
            GridView.DataSource = cmd.ExecuteReader();
            GridView.DataBind();
        }
    }
}