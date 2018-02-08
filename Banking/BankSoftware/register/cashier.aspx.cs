using System;
using System.Drawing;
using System.Web.UI;
using BusinessLayer;
using System.Web.Security;
using System.Text;
namespace BankSoftware
{
    public partial class cashier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            txtName.Focus();
            if (!IsPostBack)
            {            
                Wizard1.ActiveStepIndex = 0;
                txtDate.Text = DateTime.Now.ToShortDateString();
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, System.Web.UI.WebControls.WizardNavigationEventArgs e)
        {
            
            if (Wizard1.ActiveStepIndex == 2)
            {
                //md5 hashing   //ram has ram1 password
                
                var hash_pass = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPwd.Text, "MD5");
                //*********************************************

                //business logic
                BusinessLayer.UserAccess.createCashiers(txtID.Text, hash_pass, txtName.Text, txtAdd.Text, txtPhn.Text, txtEmail.Text, Convert.ToDateTime(txtDate.Text));
                lblMsg.Text = "Cashier Account Created, Successfull!!";
                lblMsg.ForeColor = Color.Green;
                BtnLogin.Visible = true;
               
            }
            
        }

        protected void Wizard1_NextButtonClick(object sender, System.Web.UI.WebControls.WizardNavigationEventArgs e)
        {
            if (Wizard1.ActiveStepIndex == 1)
            {
                lblUsr.Text = txtID.Text;
                lblPwd.Text = txtPwd.Text;
                lblName.Text = txtName.Text;
                lblAdd.Text = txtAdd.Text;
                lblPhn.Text = txtPhn.Text;
                lblEmail.Text = txtEmail.Text;
                lblDate.Text = txtDate.Text;
            }
        }

        protected void BtnLogin_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/cashierLogin.aspx");
        }
    }
}