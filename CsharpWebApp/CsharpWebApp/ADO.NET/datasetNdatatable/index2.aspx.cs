using System;
using System.Data.SqlClient;
using System.Data;

namespace CsharpWebApp.ADO.NET.datasetNdatatable
{
    public partial class index2 : System.Web.UI.Page
    {
        string cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k;database=hotel";
        SqlConnection cn = null;

        string query = string.Empty;
        SqlCommand cmd = null;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            query = "select * from Movies";
            cmd = new SqlCommand(query, cn);
            DataTable dt1 = new DataTable();
            dt1.Load(cmd.ExecuteReader());
            ds.Tables.Add(dt1);
            cmd.Dispose();

            query = "select * from Customer";
            cmd = new SqlCommand(query, cn);
            DataTable dt2 = new DataTable();
            dt2.Load(cmd.ExecuteReader());
            ds.Tables.Add(dt2);
            cmd.Dispose();
            cn.Close();
        }

        protected void btnM_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void btnC_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ds.Tables[1];
            GridView1.DataBind();
        }
    }
}