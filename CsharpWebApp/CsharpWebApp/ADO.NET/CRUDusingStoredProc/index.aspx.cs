using System;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ADO.NET.CRUDusingStoredProc
{
    public partial class index : System.Web.UI.Page
    {
        string cs = "server=Nikson-PC\\SQLEXPRESS;user id=sa; password=1k2k3k4k5k6k";           //since using stored p[rocedure, no need of databse name
        SqlConnection cn = null;

        string query = string.Empty;
        SqlCommand cmd = null;
        void GridFill()
        {

            cmd = new SqlCommand("spAlldata", cn);
            cmd.CommandType = CommandType.StoredProcedure;          
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
            cmd.Dispose();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cs);
            cn.Open();
            lbl.Text = "Connection established!!";


            GridFill();
        }
        void ClearAll() {
            txtAptNo.Text = txtEmail.Text = txtName.Text = txtPhone.Text = txtResID.Text = string.Empty;
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // query = "select * from resident where ResID=@ResID";
                cmd = new SqlCommand("data", cn);
                cmd.Parameters.AddWithValue("@ResID", txtResID.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtName.Text = dr[1].ToString();
                    txtAptNo.Text = dr[2].ToString();
                    txtPhone.Text = dr[3].ToString();
                    txtEmail.Text = dr[4].ToString();
                    lblResult.Text ="ID: "+ txtResID.Text +", Records Found!!";
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    
                }
                else { lblResult.Text = "There is no such Record!!";
                       lblResult.ForeColor = System.Drawing.Color.Red;
                       ClearAll();
                }
                cmd.Dispose();
            }
            catch (Exception ex) { lblResult.Text = "Eror" + ex.Message; }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("spInsert", cn);
                cmd.Parameters.AddWithValue("@ResID", txtResID.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@AptNumber", txtAptNo.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                lblResult.Text = "Records Added!!";
                lblResult.ForeColor = System.Drawing.Color.Green;
                ClearAll(); GridFill();
            }
            catch (Exception ex) { lblResult.Text = "Error" + ex.Message; lblResult.ForeColor = System.Drawing.Color.Red; }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("spDelete", cn);
                cmd.Parameters.AddWithValue("@ResID", txtResID.Text);      
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                lblResult.Text = "Records Deleted!!";
                lblResult.ForeColor = System.Drawing.Color.Green;
                ClearAll(); GridFill();
            }
            catch (Exception ex) { lblResult.Text = "Error" + ex.Message; lblResult.ForeColor = System.Drawing.Color.Red; }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("spUpdate", cn);
                cmd.Parameters.AddWithValue("@ResID", txtResID.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@AptNumber", txtAptNo.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                lblResult.Text = "Records Updated!!";
                lblResult.ForeColor = System.Drawing.Color.Green;
                ClearAll(); GridFill();
            }
            catch (Exception ex) { lblResult.Text = "Error" + ex.Message; lblResult.ForeColor = System.Drawing.Color.Red; }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}