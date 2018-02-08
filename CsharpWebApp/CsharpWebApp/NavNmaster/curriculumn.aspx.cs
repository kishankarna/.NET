using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
namespace CsharpWebApp.NavNmaster
{
   
    
    public partial class curriculumn : System.Web.UI.Page
    {
        string cs = string.Empty;
        string query = string.Empty;
        SqlConnection cn = null;
        SqlCommand cmd = null;

        void FillGrid(string nameTable) {
            query = "select * from "+ nameTable ;
            cmd = new SqlCommand(query, cn);

            GridView.DataSource = cmd.ExecuteReader();
            GridView.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = "server=Nikson-PC\\SQLEXPRESS; user id=sa;password=1k2k3k4k5k6k; database=college";
            cn = new SqlConnection(cs);
            cn.Open();
            
        }

        protected void btnTeacher_Click(object sender, EventArgs e)
        {

            FillGrid("teacher");
            
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            GridView.DataSource = null;
            GridView.DataBind();
            
        }

        protected void btnStudent_Click(object sender, EventArgs e)
        {
            FillGrid("student");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}