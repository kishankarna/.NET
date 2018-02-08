using System;
using System.Data;
using System.Web.UI.WebControls;  //giving ListItem
using System.Collections.Generic;
namespace CsharpWebApp.ASP.NET_Server_Controls.DropDownLSt_with_XML
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataSet ds = new DataSet();
            string path = Server.MapPath("~/XMLDATA/countries.xml");        //returns physical path for given virtual path
            ds.ReadXml(path);
            
            DropDownList1.DataTextField = "countryName";
            DropDownList1.DataValueField = "countryID";
            DropDownList1.DataSource = ds;
            DropDownList1.DataBind();
           
            //DropDownList is a collection of ListItem Objects
            ListItem i = new ListItem("Select","-1");
            DropDownList1.Items.Insert(0, i);
           //ropDownList1.Items.Insert(0,"Select");
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedValue == "-1")
            {
                Response.Write("Please select the country!!");
            }
            else {

                lbl.Text = DropDownList2.SelectedItem.Text;
            }
        }
    }
}