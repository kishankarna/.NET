using System;
using System.Data.SqlClient;

namespace CsharpWebApp.StateManagement.querystringwADO
{
    public partial class form2 : System.Web.UI.Page
    {
        string cs = string.Empty;
        SqlConnection cn = null;
        string dataB = string.Empty;

        string query = string.Empty;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            dataB = Request.QueryString["database"];
            cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k;database=" + dataB;

            cn = new SqlConnection(cs);
            cn.Open();

            Label1.Text = "Selected database is : " + dataB;

            query = "select name from sys.tables";
            cmd = new SqlCommand(query, cn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                ListBox1 .Items.Add(dr[0].ToString());

           
        }

  

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = ListBox1.SelectedValue;
            Response.Redirect("form3.aspx?database=" + dataB + "&table=" + tableName);
        }
    }
}