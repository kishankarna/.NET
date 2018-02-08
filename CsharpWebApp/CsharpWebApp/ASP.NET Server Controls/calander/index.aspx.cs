using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ASP.NET_Server_Controls.calander
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                Calendar2.Visible = false;
            }
        }

        protected void btnCFirst_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible == false) { Calendar1.Visible = true; }
            else { Calendar1.Visible = false; }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate1.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

       

        protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsOtherMonth || e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.Red;

            }
        }

        protected void btnCSecond_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar2.Visible == false) { Calendar2.Visible = true; }
            else { Calendar2.Visible = false; }
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            txtDate2.Text = Calendar2.SelectedDate.ToShortDateString();
            Calendar2.Visible = false;
        }
    }

   
}
