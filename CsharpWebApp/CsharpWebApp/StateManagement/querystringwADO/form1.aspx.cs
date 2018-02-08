using System;
using System.Data.SqlClient;

namespace CsharpWebApp.StateManagement.querystringwADO
{
    public partial class form1 : System.Web.UI.Page
    {
        string cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k;";
        SqlConnection cn = null;

        string query = string.Empty;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            cn = new SqlConnection(cs);
            cn.Open();
            Response.Write("Connection established!!");

            query = "select name from sys.databases";
            cmd = new SqlCommand(query, cn);
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
                DrpListDatabases.Items.Add(dr[0].ToString());
        
        }

        protected void DrpListDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            Response.Redirect("form2.aspx?database=" + DrpListDatabases.Text);
            

        }
    }
}