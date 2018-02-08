using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
namespace BankSoftware
{
    public partial class transaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

         
         
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;


            if (!IsPostBack)
            {
                PanelDeposit.Visible = false;
                PanelTransfer.Visible = false;
                PanelWithdraw.Visible = false;
                lblDepDate.Text = DateTime.Now.ToShortDateString();
                lblDateT.Text = DateTime.Now.ToShortDateString();
                lblDateW.Text = DateTime.Now.ToShortDateString();
                if (Session["name"] != null)
                {
                    lblUsr.Text = "Current User : " + Session["name"].ToString();
                    txtAccountWithdraw.Text=txtAccountTransfer.Text= txtAccountDeposit.Text = Session["account"].ToString();
                    
                    lblUsr.ForeColor = Color.Green;
                }
                else
                {
                    lblUsr.Text = "Please Log in First!!";
                    lblUsr.ForeColor = Color.Red;
                }
            }
        }



        protected void BtnDeposit_Click(object sender, EventArgs e)
        {
            PanelDeposit.Visible = true;
            PanelTransfer.Visible = false;
            PanelWithdraw.Visible = false;
            BtnWithdraw.Visible = false;
            BtnTransfer.Visible = false;
            BtnDeposit.Visible = false;
            lblMsg.Text = string.Empty;
            DDLaccTypeDeposit.SelectedIndex = 1;
        }

        protected void BtnWithdraw_Click(object sender, EventArgs e)
        {
            PanelDeposit.Visible = false;
            PanelTransfer.Visible = false;
            PanelWithdraw.Visible = true;
            BtnDeposit.Visible = false;
            BtnTransfer.Visible = false;
            BtnWithdraw.Visible = false;
            lblMsg.Text = string.Empty;
            DDLAccnTypeWithd.SelectedIndex = 1;
        }

        protected void BtnTransfer_Click(object sender, EventArgs e)
        {
            PanelDeposit.Visible = false;
            PanelTransfer.Visible = true;
            PanelWithdraw.Visible = false;
            BtnDeposit.Visible = false;
            BtnWithdraw.Visible = false;
            BtnTransfer.Visible = false;
            lblMsg.Text = string.Empty;
        }

        protected void DDLWithdrawFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmitDeposit_Click(object sender, EventArgs e)
        {
            string Usr = null;
            if (CheckUsrDeposit.Checked)
            {
                Usr = "Cashier";
            }
            else {
                Usr = "Customer";
            }
            if (DDLaccTypeDeposit.SelectedValue != "-1" && DDLDepositFrom.SelectedValue != "-1")
            {
                string usrID = Session["name"].ToString();
                double bal = accounts.GetAccountBalance(txtAccountDeposit.Text );                          //getting balance from account table
                double newBal = bal + Convert.ToDouble(txtAmountDeposit.Text); 
                accounts.Deposits(txtAccountDeposit.Text,newBal);                    //update account table
                CRUD_Operations.Deposits(Convert.ToDateTime(lblDepDate.Text), usrID, DDLaccTypeDeposit.Text+" Deposit",         //recording to transaction table
                    Convert.ToDouble(txtAmountDeposit.Text), Usr, DDLDepositFrom.Text,txtAccountDeposit.Text,newBal );
                lblMsg.Text = "Deposit Successfull!!"; lblMsg.ForeColor = Color.Green;
                BtnDeposit.Visible = true;
                BtnWithdraw.Visible = true;
                BtnTransfer.Visible = true;
                PanelDeposit.Visible = false;
                txtAmountDeposit.Text = string.Empty;
                DDLDepositFrom.SelectedIndex = 0;
                DDLaccTypeDeposit.SelectedIndex = 0;
                CheckUsrDeposit.Checked = false;
            }
            else
            {
                lblMsg.Text = "Select all the options!!";
                lblMsg.ForeColor = Color.Red;
            }
        }

        protected void btnCancelDeposit_Click(object sender, EventArgs e)
        {
            PanelDeposit.Visible = false;
            BtnWithdraw.Visible = true;
            BtnTransfer.Visible = true;
            BtnDeposit.Visible = true;    
        }

        protected void btnCancelWithdraw_Click(object sender, EventArgs e)
        {
            PanelWithdraw.Visible = false;
            BtnDeposit.Visible = true;
            BtnTransfer.Visible = true;
            BtnWithdraw.Visible = true;
        }

        protected void btnCancelTransfer_Click(object sender, EventArgs e)
        {
            PanelTransfer.Visible = false;
            BtnDeposit.Visible = true;
            BtnWithdraw.Visible = true;
            BtnTransfer.Visible = true;
        }

        protected void CheckUsrDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckUsrDeposit.Checked)
            {
                txtAccountDeposit.Enabled = true;
            }
            else
            {
                txtAccountDeposit.Enabled = false;
            }
        }

        protected void btnSubmitWithdraw_Click(object sender, EventArgs e)
        {
            string Usr = null;
            if (CheckUsrWithdraw.Checked)
            {
                Usr = "Cashier";
            }
            else
            {
                Usr = "Customer";
            }
            if (DDLAccnTypeWithd.SelectedValue != "-1" && DDLWithdrawFrom.SelectedValue != "-1")
            {
                double newBal = 0;
                string usrID = Session["name"].ToString();
                double bal = accounts.GetAccountBalance(txtAccountWithdraw.Text);                          //getting balance from account table
                double amount = Convert.ToDouble(txtAmountWithdraw.Text );
                if (bal > amount)
                {
                    newBal = bal - Convert.ToDouble(txtAmountWithdraw.Text);
                    accounts.Deposits(txtAccountDeposit.Text, newBal);                    //update account table
                    CRUD_Operations.Deposits(Convert.ToDateTime(lblDateW.Text), usrID, DDLAccnTypeWithd.Text+" Withdraw",         //recording to transaction table
                        Convert.ToDouble("-"+txtAmountWithdraw.Text), Usr, DDLWithdrawFrom.Text, txtAccountWithdraw.Text,newBal);
                    lblMsg.Text = "Withdraw Successfull!!"; lblMsg.ForeColor = Color.Green;
                    BtnDeposit.Visible = true;
                    BtnWithdraw.Visible = true;
                    BtnTransfer.Visible = true;
                    PanelWithdraw.Visible = false;
                    txtAmountWithdraw.Text = string.Empty;
                    DDLWithdrawFrom.SelectedIndex = 0;
                    DDLAccnTypeWithd.SelectedIndex = 0;
                    CheckUsrWithdraw.Checked = false;
                }
                else
                {
                    lblMsg.Text = "Amount not succifienct!!";lblMsg.ForeColor = Color.Red;txtAmountWithdraw.Focus();
                }
               
            }
            else
            {
                lblMsg.Text = "Select all the options!!";
                lblMsg.ForeColor = Color.Red;
            }

        }




        protected void CheckUsrWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckUsrWithdraw.Checked)
            {
                txtAccountWithdraw.Enabled = true;
            }
            else
            {
                txtAccountWithdraw.Enabled = false;
            }
        }

        protected void CheckUsrTrans_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckUsrTrans.Checked)
            {
                txtAccountTransfer.Enabled = true;
            }
            else
            {
                txtAccountTransfer.Enabled = false;
            }
        }

        protected void btnSubmitTransfer_Click(object sender, EventArgs e)
        {
            PanelTransfer.Visible = false;
            BtnDeposit.Visible = true;
            BtnWithdraw.Visible = true;
            BtnTransfer.Visible = true;
        }

      
    }
}