using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ASP.NET_Server_Controls.wizardControl2
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Wizard1.ActiveStepIndex = 0;
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Wizard1.ActiveStepIndex == 0)
            {
                Wizard1.HeaderText = "Personal Details";
                TxtFname.Focus();
            }
            else if (Wizard1.ActiveStepIndex == 1)
            {
                Wizard1.HeaderText = "Contact Details";
                TxtAdd.Focus();
            }
            else if (Wizard1.ActiveStepIndex == 2)
            {
                Wizard1.HeaderText = "Summary";
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            // Response.Write("Hello");
            if (e.NextStepIndex == 2)           //catches if it is in 3 step
            {
                lblFName.Text = TxtFname.Text;
                LblLname.Text = TxtLname.Text;
                if(rdMale.Checked)
                    lblGender.Text = "Male";
                else
                     lblGender.Text = "Female";
                lblAdd.Text = TxtAdd.Text;
                lblEmail.Text = TxtEmail.Text;
                lblPhn.Text = TxtPhn.Text;
            }
        }
    }
}