using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ADO.NET.querystring
{
    public partial class form1 : System.Web.UI.Page
    {
       

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // we use Server.UrlEncode to catch error if the user provdes & in textbox
            Response.Redirect("form2.aspx?name="+Server.UrlEncode( txtName.Text) +"&address="+Server.UrlEncode( txtAddress.Text) );
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}