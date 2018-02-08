using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.Navigation.AllNavigations
{
    public partial class form2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //response redirect but, not hyperlink
            //can use session , query string, etc. to transfer the data to another page
            //****************************************
            //for server.transfer information retrieval     //this can retrieve even it is Server.Transfer("form2.aspx",false); while sending data
            //Page p = Page.PreviousPage;
            //if (p != null)
            //{
            //    lblName.Text= ((TextBox)p.FindControl("TxtName")).Text;
            //    lblEmail.Text = ((TextBox)p.FindControl("TxtEmail")).Text;
            //}
            //**************another technique to retrieve  //this can not rerieve data if it is Server.Transfer("form2.aspx",false); while sending data
            //System.Collections.Specialized.NameValueCollection preForm = Request.Form;
            //lblName.Text=  preForm["TxtName"];
            //lblEmail.Text = preForm["TxtEmail"];
            //********************************************

            //****************to land on this page if only crosspagePostback was implemented
            // this can retrieve data if even Server.Transfer("form2.aspx",false); or Server.Execute("form2.aspx",false);
            //that is why we do below technique
            Page p = Page.PreviousPage;
            if (p != null && p.IsCrossPagePostBack)
            {
                lblName.Text = ((TextBox)p.FindControl("TxtName")).Text;
                lblEmail.Text = ((TextBox)p.FindControl("TxtEmail")).Text;
            }

        }


    }
}