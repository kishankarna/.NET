using System;
using System.Drawing;

namespace CsharpWebApp.StateManagement.Session3
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                lblUser.Text = Session["user"].ToString();
                lblUser.ForeColor = Color.Blue;
            }
            else {
                lblUser.Text = "Please Login First"; lblUser.ForeColor = Color.Red;
            }
        }
    }
}