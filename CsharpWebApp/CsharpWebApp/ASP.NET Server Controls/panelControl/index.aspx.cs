using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ASP.NET_Server_Controls.panelControl
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PanelAdmin.Visible = false; PanelGuest.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblAdmin.Text = TxtAdmnName.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            lblGuest.Text = TxtGuestName.Text;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue=="-1")
            {
                PanelAdmin.Visible = false; PanelGuest.Visible = false;
            }
            else if (DropDownList1.SelectedValue=="Admin")
            {
                PanelAdmin.Visible = true; PanelGuest.Visible = false;
            }
            else
            {
                PanelAdmin.Visible = false; PanelGuest.Visible = true;
            }
        }
    }
}