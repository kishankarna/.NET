using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ValidatiionControl
{
    public partial class control1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
           
                lbl.Text = "Congratulations!!";
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            lblMsg.Text=  txtEvenNumber.Text;
        }
    }
}