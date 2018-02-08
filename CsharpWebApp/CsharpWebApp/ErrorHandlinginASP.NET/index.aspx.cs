using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.Error_Handling_in_ASP.NET
{
    public partial class index : System.Web.UI.Page 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                DataSet ds = new DataSet();         //here we gave wrong path
                ds.ReadXml(Server.MapPath("./xmlFile/admin/countries.xml"));

                GridView1.DataSource = ds;
                GridView1.DataBind();
             

        }
        protected void Page_Error(object sender, EventArgs e)
        {    // Get the exception details and log it in the database or event viewer
            Exception ex = Server.GetLastError();
            // Clear the exception
            Server.ClearError();
            // Redirect user to Error page
            Response.Redirect("~/ErrorHandlinginASP.NET/error.aspx");



        }
        protected void btnCountry_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("./xmlFile/countries.xml"));

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void btnException_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();         //here we gave wrong path
                ds.ReadXml(Server.MapPath("./xmlFile/admin/countries.xml"));

                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                lblMsg.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error" + ex.Message;
            }
            finally
            {
                // clean code like close database connection etc
            }
        }

      


    }
}