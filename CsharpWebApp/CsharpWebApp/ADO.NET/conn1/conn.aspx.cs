using System;
using System.Data.SqlClient;

namespace CsharpWebApp.ADO.NET.conn1
{
    public partial class conn : System.Web.UI.Page
    {
        string cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k;database=hotel";
        SqlConnection cn = null;

        string query = string.Empty;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void ClearAll() {
            txtName.Text = string.Empty;
            txtDuration.Text = string.Empty;
            txtDate.Text = string.Empty;
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {

            cn = new SqlConnection(cs);
            cn.Open();

            query = "select * from Movies where MovieID=" + txtID.Text;
            cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            ClearAll();
            if (dr.Read())
            { //txtID.Text = dr[0].ToString();
                txtName.Text = dr[1].ToString();
                txtDuration.Text = dr[2].ToString();
                txtDate.Text = dr[3].ToString();
                Label1.Text = "Record Found!!";
            }
            else
            {

                Label1.Text = "No Data Present for this ID";
                Label1.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}