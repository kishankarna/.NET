using System;
using System.Drawing;
using System.Text;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
namespace BankSoftware
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
                txtDate.Text = DateTime.Now.ToShortDateString();
            }
        }

        protected void BtnLogin_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/login.aspx");
           

        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (Wizard1.ActiveStepIndex == 3)
            {
                

                //md5 hashing   
                
                var hash_pass = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPwd.Text ,"MD5");
                //*********************************************

                //business logic
                UserAccess.createCustomer(txtID.Text, hash_pass, txtName.Text, txtAdd.Text, txtPhn.Text, txtEmail.Text,
                    txtAccn.Text ,DDLaccountType.Text ,  Convert.ToDateTime(txtDate.Text),Convert.ToDouble(txtAmount.Text) ,txtCashierID.Text );

                accounts.FirstDeposit(txtAccn.Text ,txtName.Text ,Convert.ToDouble( txtAmount.Text) ,DDLaccountType.Text );

                CRUD_Operations.Deposits(Convert.ToDateTime( txtDate.Text) ,txtID.Text,DDLaccountType.Text,Convert.ToDouble( txtAmount.Text),
                    txtCashierID.Text,"Bank",txtAccn.Text, Convert.ToDouble(txtAmount.Text));

                lblMsg.Text = "Customer Account Created, Successfull!!";
                lblMsg.ForeColor = Color.Green;
                BtnLogin.Visible = true;
                lblUsr.Text = lblPwd.Text = lblName.Text = lblAdd.Text = lblPhn.Text = lblEmail.Text = lblDate.Text =
                    lblAccn.Text = lblAmount.Text = lblCashier.Text = lblAccType.Text = string.Empty;
            }
        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (Wizard1.ActiveStepIndex == 1)
            { DDLaccountType.SelectedIndex = 1;    //only checking available as of now 
            }

                if (Wizard1.ActiveStepIndex == 2)
            {
                DDLaccountType.SelectedIndex = 1;    //only checking available as of now

                lblUsr.Text = txtID.Text;
                lblPwd.Text = txtPwd.Text;
                lblName.Text = txtName.Text;
                lblAdd.Text = txtAdd.Text;
                lblPhn.Text = txtPhn.Text;
                lblEmail.Text = txtEmail.Text;
                lblDate.Text = txtDate.Text;
                lblAccn.Text = txtAccn.Text;
                lblAmount.Text = txtAmount.Text;
                lblCashier.Text = txtCashierID.Text;
                lblAccType.Text = DDLaccountType.Text;
            }
        }

    }
}