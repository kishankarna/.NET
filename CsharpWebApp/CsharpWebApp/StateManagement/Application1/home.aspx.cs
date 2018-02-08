using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.StateManagement.Application1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TextBox1.Text = "0";
                Application["value"] = 0;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            TextBox1.Text = Convert.ToString(Convert.ToInt32(Application["value"])+1);
            Application["value"] = TextBox1.Text; 
        }
    }
}