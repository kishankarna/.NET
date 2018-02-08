using System;
using System.Data.SqlClient;

namespace CsharpWebApp.StateManagement.querystringwADO
{
    public partial class form3 : System.Web.UI.Page
    {
        string cs = string.Empty;
        SqlConnection cn = null;
       // string dataB = string.Empty;

        string query = string.Empty;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            string dataB = Request.QueryString["database"];
            string tableName = Request.QueryString["table"];
            cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k;database=" + dataB;

            cn = new SqlConnection(cs);
            cn.Open();

            lblTable.Text = "Selected table is : " + tableName ;

            query = "select * from "+tableName;
            cmd = new SqlCommand(query, cn);

            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
        }
    }
}