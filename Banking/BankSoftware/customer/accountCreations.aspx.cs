using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace BankSoftware.bank
{
    public partial class accountCreations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            txtAccn.Focus();
            if (!IsPostBack)
            {
                Wizard1.ActiveStepIndex = 0;
            }
            lblUsr.Text = Session["name"].ToString();
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (accounts.checkAccounts(txtAccn.Text) != true)  //checking account in general for all customer
            {
                string cust = Session["custid"].ToString();

                if (UserAccess.GetAccount(cust, lblAccType.Text))  //checking account for particular customer
                {
                    lblMsg.Text = "You alreay have " + lblAccType.Text + "Account with us!!";
                    lblMsg.ForeColor = Color.Red;
                }
                else
                {

                    //account creation
                    accounts.createAccounts(lblAccount.Text, lblAccType.Text, Convert.ToDouble(lblAmount.Text),
                        lblPreparer.Text, Convert.ToDateTime(lblDate.Text), Session["custid"].ToString());
                    accounts.FirstDeposit(lblAccount.Text, Session["custid"].ToString(), Convert.ToDouble(lblAmount.Text), lblAccType.Text);

                    //accounts.Deposits(lblAccount.Text, Convert.ToDouble(lblAmount.Text));
                    CRUD_Operations.Deposits(Convert.ToDateTime(DateTime.Now.ToShortDateString()), Session["custid"].ToString(), "Opening Balance",
                        Convert.ToDouble(lblAmount.Text), lblAccType.Text, "Bank", lblAccount.Text, Convert.ToDouble(lblAmount.Text));

                    lblMsg.Text = "Customer Account Created, Successfull!!";
                    lblMsg.ForeColor = Color.Green;
                    Wizard1.Enabled = false;
                }
            }

            else
            {
                lblMsg.Text = "Account number already exists!! Try another one!! Warning!!";
                lblMsg.ForeColor = Color.Red;
                Wizard1.ActiveStepIndex = 0;
                txtAccn.Focus();
                txtAccn.BackColor = Color.Red;

            }
        }
    

        protected void Wizard1_CancelButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            txtAccn.BackColor = Color.White;
            lblMsg.Text = "";
            lblCredit.Text = "";
          
                if (Wizard1.ActiveStepIndex == 0)
                {
                    lblName.Text = Session["name"].ToString();
                    lblAccount.Text = txtAccn.Text;
                    lblAmount.Text = txtBalance.Text;
                    lblAccType.Text = DDLAccnType.SelectedItem.Text;
                    lblDate.Text = DateTime.Now.ToShortDateString();
                    lblPreparer.Text = DDLPreparer.SelectedItem.Text;

                }
            if (lblAccType.Text == "Credit")
            {
                lblAmount.Text = "500"; //initial credit balance
                lblCredit.Text = "Initial Credit Limit"; lblCredit.ForeColor = Color.Red;


            }
            
        }
    }
}