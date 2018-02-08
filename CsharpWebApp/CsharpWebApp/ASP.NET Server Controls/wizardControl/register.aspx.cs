using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ASP.NET_Server_Controls.wizardControl
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                Wizard1.ActiveStepIndex = 0;
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Wizard1.ActiveStepIndex == 1)
                Wizard1.HeaderText = "Contact Details";
            else if (Wizard1.ActiveStepIndex == 2)
                Wizard1.HeaderText = "Summary";
            else
                Wizard1.HeaderText = "Personal Details";
        }
        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Redirect("home.aspx");

        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (e.NextStepIndex == 2)
            {
                lblFname.Text = txtFname.Text;
                lblLname.Text = txtLname.Text;
                if (rdMale.Checked)
                    lblGender.Text = "Male";
                else
                    lblGender.Text = "Female";
                lblAdd.Text = txtAdd.Text;
                lblEmail.Text = txtEmail.Text;
                lblPhn.Text = txtPhn.Text;
            }
        }
    }
}