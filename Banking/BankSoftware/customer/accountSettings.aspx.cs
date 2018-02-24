using System;
using System.Collections.Generic;
using System.Web.UI;
using BusinessLayer;
namespace BankSoftware.bank
{
    public partial class accountSettings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                List<string> data = new List<string>();
                data = UserAccess.GetCustomers(Session["custid"].ToString());


                lblCustID.Text = Session["custid"].ToString();
                txtName.Text = Session["name"].ToString();
                txtAddress.Text = data[0];
                txtPhone.Text = data[1];
                txtEmail.Text = data[2];
            }


        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            txtAddress.Enabled = txtEmail.Enabled= txtPhone.Enabled= true;
            btnUpdate.Enabled =btnCancel.Enabled= true;
            lblMsg.Text = "";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtAddress.Enabled = txtEmail.Enabled  = txtPhone.Enabled =btnUpdate.Enabled= btnCancel.Enabled= false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            UserAccess.EditCustomer(Session["custid"].ToString(),txtAddress.Text,txtPhone.Text,txtEmail.Text);
            lblMsg.Text = "Update Successfull!!";
            lblMsg.ForeColor = System.Drawing.Color.Green;
            btnUpdate.Enabled = false;
        }

        protected void btnDisplayInfo_Click(object sender, EventArgs e)
        {
            if (btnDisplayInfo.Text == "Display Information")
            {
                if (Session["CheckingAccountID"] != null)
                {
                    lblChecking.Text = Session["CheckingAccountID"].ToString();
                }
                else { lblChecking.Text = "Not available"; }

                if (Session["SavingAccountID"] != null)
                {
                    lblSaving.Text = Session["SavingAccountID"].ToString();
                }
                else { lblSaving.Text = "Not available"; }

                if (Session["CreditAccountID"] != null)
                {
                    lblCredit.Text = Session["CreditAccountID"].ToString();
                }
                else { lblCredit.Text = "Not available"; }
                btnDisplayInfo.Text = "Hide";
                return;
            }

            if (btnDisplayInfo.Text == "Hide")
            {
                lblChecking.Text = lblCredit.Text = lblSaving.Text = "";
                btnDisplayInfo.Text = "Display Information";

            }

        }

    }
}