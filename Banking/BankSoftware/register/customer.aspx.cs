using System;
using System.Drawing;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
namespace BankSoftware.register
{
    public partial class customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            txtName.Focus();
            if (!IsPostBack)
            {
                Wizard1.ActiveStepIndex = 0;
            }
        }

        protected void BtnLogin_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/login.aspx");
          
        }
        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
               //md5 hashing   
                
                var hash_pass = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPwd.Text ,"MD5");
               
               //business logic
                UserAccess.createCustomer(txtID.Text, hash_pass, txtName.Text, txtAdd.Text, txtPhn.Text, txtEmail.Text);
                 
                        
                lblMsg.Text = "Customer Account Created, Successfull!!";
                lblMsg.ForeColor = Color.Green;
                BtnLogin.Visible = true;
                lblUsr.Text = lblPwd.Text = lblName.Text = lblAdd.Text = lblPhn.Text = lblEmail.Text = string.Empty;

            Wizard1.Enabled = false;
        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
           
           if (Wizard1.ActiveStepIndex == 1)
            {
                lblUsr.Text = txtID.Text;
                lblPwd.Text = txtPwd.Text;
                lblName.Text = txtName.Text;
                lblAdd.Text = txtAdd.Text;
                lblPhn.Text = txtPhn.Text;
                lblEmail.Text = txtEmail.Text;
               
            }
        }

        protected void Wizard1_CancelButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
    }
}