using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ASP.NET_Server_Controls.CascadingDropDwnLstControl
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // ListItem item = 
            DropDownList1.Items.Insert(0, new ListItem("Select", "-1"));
            DropDownList1.DataBind();
        }
    }
}