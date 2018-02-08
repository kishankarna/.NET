using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.StateManagement
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text  = DateTime.Now.ToLongTimeString();
            Label1.ForeColor = Color.Green;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = DateTime.Now.ToLongTimeString();
            Label2.ForeColor = Color.Green;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label3.Text = Calendar1.SelectedDate.ToLongDateString(); 
        }
    }
}