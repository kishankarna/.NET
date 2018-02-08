using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace CsharpWebApp.ASP.NET_Server_Controls.HiddenField
{
    public partial class index : System.Web.UI.Page
    { 
        string cs=string.Empty;
        SqlConnection cn = null;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs= "server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k;database=college";
            cn = new SqlConnection(cs);
            cn.Open();
            Response.Write("Connection established");


            string query = "Select * from student";
            cmd = new SqlCommand(query, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtAddress.Text = dr[2].ToString();
                txtPhone.Text = dr[3].ToString();
                txtBatch.Text = dr[4].ToString();
                hiddenIdField.Value = dr[0].ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lbl.Text = hiddenIdField.Value;
        }
    }
}
