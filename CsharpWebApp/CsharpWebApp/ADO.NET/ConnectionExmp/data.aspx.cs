using System;
using System.Data.SqlClient;

namespace CsharpWebApp.ADO.NET.ConnectionExmp
{
    public partial class data : System.Web.UI.Page
    {
        string cs = string.Empty;
        SqlConnection cn = null;
        SqlCommand cmd = null;
        string query = string.Empty;
        public data() {
          //  cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=hotel";
            //cn = new SqlConnection(cs);

        }

        void FillGrid(string table,string cs) {
            cn = new SqlConnection(cs);
            cn.Open();
            query = "select * from " + table;
            cmd = new SqlCommand(query, cn);

            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
        }
        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=hotel";
            FillGrid("Customer",cs);
            lbl.Text = "Customer Records!!";
        }

        protected void btnMovie_Click(object sender, EventArgs e)
        {
            cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=hotel";
            FillGrid("Movies",cs);
            lbl.Text = "Movies Records!!";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            lbl.Text = "Cleared Data!!!!";
        }

        protected void btnStudnet_Click(object sender, EventArgs e)
        {
            cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=college";
            FillGrid("student", cs);
            lbl.Text = "Student Records!!";
        }

        protected void btnTeacher_Click(object sender, EventArgs e)
        {
            cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k;database=college";
            FillGrid("teacher", cs);
            lbl.Text = "Teacher Records!!";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}