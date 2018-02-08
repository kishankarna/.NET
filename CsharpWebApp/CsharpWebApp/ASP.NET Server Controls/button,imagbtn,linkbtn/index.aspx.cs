using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ASP.NET_Server_Controls.CommandBtn
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            txt.Text = "U clicked me";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "U clicked this link button";
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            TextBox2.Text = "U clicked image button!!";
        }
    }
}