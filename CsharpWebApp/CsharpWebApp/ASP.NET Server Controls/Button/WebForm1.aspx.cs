using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ASP.NET_Server_Controls.Button
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnDynamic.Click += new EventHandler(btnDynamic_Click);
            btnDynamic.Command += new CommandEventHandler(btnDynamic_Command);
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            Response.Write("This is click event on server side!!<br/>");
        }

        protected void btnClick_Command(object sender, CommandEventArgs e)
        {
            Response.Write("This is command event on server side!!");
        }

        protected void btnDynamic_Click(object sender, EventArgs e)
        {
            Response.Write("This is from second button click event and event is designed in page load<br/>");
        }

        protected void btnDynamic_Command(object sender, CommandEventArgs e)
        {
            Response.Write("This is from second button command event and event is designed in page load<br/>");
        }

       
    }
}