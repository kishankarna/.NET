using System;
using System.Data.SqlClient;

namespace CsharpWebApp.ADO.NET.conn
{
    public partial class conn : System.Web.UI.Page
    {
        string cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k;database=hotel";
        SqlConnection cn = null;

        string query = string.Empty;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();

            Label1.Text="Connection Esatblished";


        }

        protected void btnMovie_Click(object sender, EventArgs e)
        {
            query = "select * from Movies";
            cmd = new SqlCommand(query,cn);

            SqlDataReader dr= cmd.ExecuteReader();

            GridView1.DataSource = dr;
            GridView1.DataBind();
        }
    }
}