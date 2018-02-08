using System;
using System.Data.SqlClient;
using System.Data;

namespace CsharpWebApp.ADO.NET.datasetNdatatable
{
    public partial class index : System.Web.UI.Page
    {

        string cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k;database=hotel";
        SqlConnection cn = null;

        string query = string.Empty;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
          
                cn = new SqlConnection(cs);
                cn.Open();


                query = "select * from Movies";
                cmd = new SqlCommand(query, cn);
                // dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                lbl.Text = "Connection Established";
                cmd.Dispose();

                query = "select * from Customer";
                cmd = new SqlCommand(query, cn);
                dt2.Load(cmd.ExecuteReader());
                cmd.Dispose();
                cn.Close();
           
                       
        }
   
        protected void btnD_Click(object sender, EventArgs e)
        {


            GridView1.DataSource = dt;
            GridView1.DataBind();
            lbl.Text = "Movies Name";


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = dt2;
            GridView1.DataBind();
            lbl.Text = "Custoemer Names";
        }

       
    }
}