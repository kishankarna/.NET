using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.Navigation.AllNavigations
{
    public partial class form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnResponse_Click(object sender, EventArgs e)
        {
            Response.Redirect("form2.aspx");
            
        }

        protected void BtnServerTrans_Click(object sender, EventArgs e)
        {
            //Server.Transfer("form2.aspx");    
            Server.Transfer("form2.aspx",false); //this will not transfer the data for request.form b'coz  technique it is false
            lblStatus.Text = "Completed Sucessfully";
            lblStatus.ForeColor = System.Drawing.Color.Red;
        }

        protected void BtnServerExec_Click(object sender, EventArgs e)
        {
            //Server.Execute("form2.aspx");
            Server.Execute("form2.aspx", false);    //this is not transfor the data form request.form technique b'coz it is false
            lblStatus.Text = "Completed Sucessfully";
            lblStatus.ForeColor = System.Drawing.Color.Red;
        }

        protected void BtnCrossPgPostBack_Click(object sender, EventArgs e)
        {

        }
    }
}