using System;
using System.Data.SqlClient;


namespace CsharpWebApp.ADO.NET.conn1
{
    public partial class conn2 : System.Web.UI.Page
    {
        string cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k;database=hotel";
        SqlConnection cn = null;
        SqlDataReader dr = null;
        string query = string.Empty;
        SqlCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();

            if (!IsPostBack)
            {
                query = "select MovieID from Movies";
                cmd = new SqlCommand(query, cn);
                dr = cmd.ExecuteReader();
                DropDownList1.Items.Add("SELECT");
                while (dr.Read())
                    DropDownList1.Items.Add(dr[0].ToString());
                cmd.Dispose();
                dr.Close();
            }
        }
        void ClearAll()
        {
            txtName.Text = string.Empty;
            txtDuration.Text = string.Empty;
            txtDate.Text = string.Empty;
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                ClearAll();
                query = "select * from Movies where MovieID=" + DropDownList1.SelectedValue;
                cmd = new SqlCommand(query, cn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                { //txtID.Text = dr[0].ToString();
                    txtName.Text = dr[1].ToString();
                    txtDuration.Text = dr[2].ToString();
                    txtDate.Text = dr[3].ToString();
                    Label1.Text = "Record Found!!";
                    Label1.ForeColor = System.Drawing.Color.Green;
                }
                cmd.Dispose();
                dr.Close();
            }
            catch {
                Label1.Text = "Please Select!!";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}