using System;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ADO.NET.CRUD_Operation
{
    public partial class index : System.Web.UI.Page
    {
        string cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa;password=1k2k3k4k5k6k ;database=hotel";
        SqlConnection cn = null;

        string query = string.Empty;
        SqlCommand cmd = null;

        SqlDataReader dr = null;
        void GridFill() {
            query = "select * from cust";
            cmd = new SqlCommand(query, cn);
          
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
            cmd.Dispose();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            Response.Write("Database connection successfull");

            GridFill();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            query = "select * from cust where id =@id" ;
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtID.Text = dr[0].ToString();
                txtName.Text = dr[1].ToString();
                txtAddress.Text = dr[2].ToString();
                txtPhone.Text = dr[3].ToString();
                Label1.Text = "Data Found!!";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            else { Label1.Text = txtID.Text +" value does not exist!!"; Label1.ForeColor = System.Drawing.Color.Red; }

            dr.Close();
            cmd.Dispose();
            GridFill();

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            query = "insert into cust values(@Name,@Address,@Phone)";
            cmd = new SqlCommand(query, cn);
            //cmd.Parameters.AddWithValue("@id",txtID.Text);
            cmd.Parameters.AddWithValue("@Name",txtName.Text );
            cmd.Parameters.AddWithValue("@Address",txtAddress .Text);
            cmd.Parameters.AddWithValue("@Phone",txtPhone.Text );
            int i = cmd.ExecuteNonQuery();

            Label1.Text = i + " value inserted";
            Label1.ForeColor = System.Drawing.Color.Green;
            txtID.Text = txtName.Text = txtAddress.Text = txtPhone.Text = string.Empty;
            cmd.Dispose();
            GridFill();
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            query = "delete from cust where id=@id";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id",txtID.Text);
            
            int i = cmd.ExecuteNonQuery();

            Label1.Text = i + " value Deleted";
            Label1.ForeColor = System.Drawing.Color.Green;
            txtID.Text = txtName.Text = txtAddress.Text = txtPhone.Text = string.Empty;
            cmd.Dispose();
            GridFill();
        }

        protected void btnUpdat_Click(object sender, EventArgs e)
        {
            query = "update cust set name=@name, address=@address, phone=@phone where id=@id";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            int i = cmd.ExecuteNonQuery();

            Label1.Text = i + " value Updated";
            Label1.ForeColor = System.Drawing.Color.Green;
            txtID.Text = txtName.Text = txtAddress.Text = txtPhone.Text = string.Empty;
            cmd.Dispose();
            GridFill();
        }

      
    }
}