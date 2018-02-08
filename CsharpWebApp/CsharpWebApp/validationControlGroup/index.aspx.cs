using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.validationControlGroup
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            
        }

        protected void BtnLog_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (TxtLusr.Text == "karna" && TxtLPwd.Text == "karna1")
                {
                    lblLog.Text = "Logged in Successfull!!";
                    lblLog.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblLog.Text = "Validation Failed!!";
                lblLog.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void BtnRegst_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblR.Text = "Registration Successfull!!";
                lblR.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblR.Text = "Validation Failed";
                lblR.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            TxtRusr.Text = TxtRPwd.Text = TxtRCpss.Text = TxtREmail.Text = string.Empty;
        }
    }
}