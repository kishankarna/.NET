﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
namespace BankSoftware.bank
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
                
                    lblUsr.Text = "Current User : " + Session["name"].ToString();                       
                    lblUsr.ForeColor = Color.Green;
                //for  options
                if (Session["CheckingAccountID"] != null)
                {
                    DDLDepositTo.Items.Add("Checking");
                    DDLWithdrawFrom.Items.Add("Checking");
                    DDLTransTo.Items.Add("Checking");
                    DDLTransFrom.Items.Add("Checking");
                }
                if (Session["SavingAccountID"] != null)
                {
                    DDLDepositTo.Items.Add("Saving");
                    DDLWithdrawFrom.Items.Add("Saving");
                    DDLTransTo.Items.Add("Saving");
                    DDLTransFrom.Items.Add("Saving");
                }
            }
        }
        protected void BtnDeposit_Click(object sender, EventArgs e)
        {
            if (Session["CheckingAccountID"] != null || Session["SavingAccountID"]!=null || Session["CreditAccountID"]!=null)
            {
                PanelDeposit.Visible = true;
                PanelTransfer.Visible = false;
                PanelWithdraw.Visible = false;
                BtnWithdraw.Visible = false;
                BtnTransfer.Visible = false;
                BtnDeposit.Visible = false;
                lblMsg.Text = string.Empty;
                DepositTxtCustID.Text = Session["custid"].ToString();
            }
            else
            {
                lblMsg.Text = "Create Account First!!";
                lblMsg.ForeColor = Color.Red;
            }
        }

        protected void BtnWithdraw_Click(object sender, EventArgs e)
        {
            if (Session["CheckingAccountID"] != null || Session["SavingAccountID"] != null || Session["CreditAccountID"] != null)
            {
                PanelDeposit.Visible = false;
                PanelTransfer.Visible = false;
                PanelWithdraw.Visible = true;
                BtnDeposit.Visible = false;
                BtnTransfer.Visible = false;
                BtnWithdraw.Visible = false;
                lblMsg.Text = string.Empty;
                WithdrawTxtCustID.Text = Session["custid"].ToString();
            }
            else
            {
                lblMsg.Text = "Create Account First!!";
                lblMsg.ForeColor = Color.Red;
            }
        }

        protected void BtnTransfer_Click(object sender, EventArgs e)
        {
            if (Session["CheckingAccountID"] != null || Session["SavingAccountID"] != null || Session["CreditAccountID"] != null)
            {
            PanelDeposit.Visible = false;
            PanelTransfer.Visible = true;
            PanelWithdraw.Visible = false;
            BtnDeposit.Visible = false;
            BtnWithdraw.Visible = false;
            BtnTransfer.Visible = false;
            lblMsg.Text = string.Empty;
            TransferTxtCustID.Text = Session["custid"].ToString();
            }
            else
            {
                lblMsg.Text = "Create Account First!!";
                lblMsg.ForeColor = Color.Red;
            }
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
                string usrID = Session["custid"].ToString();
                double bal = 0;
                //for checking
                if (DDLDepositTo.SelectedIndex == 1 && (Session["CheckingAccountID"] != null || Session["SavingAccountID"] != null || Session["CreditAccountID"] != null))
                {
                    bal = accounts.GetAccountBalance(Session["CheckingAccountID"].ToString());      //getting balance from account table
                    double newBal = bal + Convert.ToDouble(txtAmountDeposit.Text);
                    accounts.Deposits(Session["CheckingAccountID"].ToString(), newBal);          //update accountSummary table
                    CRUD_Operations.Deposits(Convert.ToDateTime(lblDepDate.Text), usrID, DDLDepositTo.Text + " Deposit",         //recording to transaction table
                         Convert.ToDouble(txtAmountDeposit.Text), Usr, DDLDepositDescrip.Text, Session["CheckingAccountID"].ToString(), newBal);
                    D1();
                    return;
                 }
                else {
                    lblMsg.Text = "Create " + DDLDepositTo.SelectedItem.Text +"First";
                }
                 //for saving
                 if (DDLDepositTo.SelectedIndex == 2 && (Session["CheckingAccountID"] != null || Session["SavingAccountID"] != null || Session["CreditAccountID"] != null))
                {
                    bal = accounts.GetAccountBalance(Session["SavingAccountID"].ToString());
                    double newBal = bal + Convert.ToDouble(txtAmountDeposit.Text);
                    accounts.Deposits(Session["SavingAccountID"].ToString(), newBal);          //update accountSummary table
                    CRUD_Operations.Deposits(Convert.ToDateTime(lblDepDate.Text), usrID, DDLDepositTo.Text + " Deposit",         //recording to transaction table
                         Convert.ToDouble(txtAmountDeposit.Text), Usr, DDLDepositDescrip.Text, Session["SavingAccountID"].ToString(), newBal);
                    D1();
                    return;
                }
                else
                {
                    lblMsg.Text = "Create " + DDLDepositTo.SelectedItem.Text + "First";
                }
                
        }

        private void D1() {
            lblMsg.Text = "Deposit Successfull!!"; lblMsg.ForeColor = Color.Green;
            BtnDeposit.Visible = true;
            BtnWithdraw.Visible = true;
            BtnTransfer.Visible = true;
            PanelDeposit.Visible = false;
            txtAmountDeposit.Text = string.Empty;
            DDLDepositDescrip.SelectedIndex = 0;
            DDLDepositTo.SelectedIndex = 0;
            CheckUsrDeposit.Checked = false;
        }
    
        protected void btnCancelDeposit_Click(object sender, EventArgs e)
        {
            PanelDeposit.Visible = false; BtnWithdraw.Visible = true; BtnTransfer.Visible = true; BtnDeposit.Visible = true;    
        }

        protected void btnCancelWithdraw_Click(object sender, EventArgs e)
        {
            PanelWithdraw.Visible = false; BtnDeposit.Visible = true; BtnTransfer.Visible = true; BtnWithdraw.Visible = true;
        }

        protected void btnCancelTransfer_Click(object sender, EventArgs e)
        {
            PanelTransfer.Visible = false; BtnDeposit.Visible = true; BtnWithdraw.Visible = true; BtnTransfer.Visible = true;
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
           
                double bal = 0;
                string usrID = Session["custid"].ToString();
                double amount = Convert.ToDouble(txtAmountWithdraw.Text);
                //for checking
                if (DDLWithdrawFrom.SelectedIndex == 1 && (Session["CheckingAccountID"] != null || Session["SavingAccountID"] != null || Session["CreditAccountID"] != null))
                {
                    bal = accounts.GetAccountBalance(Session["CheckingAccountID"].ToString());                     //getting balance from account table
                                                                                                                 // bal = accounts.GetAccountBalance(Session["CheckingAccountID"].ToString());      //getting balance from account table
                    if (bal > amount)
                    {
                        double newBal = bal - Convert.ToDouble(txtAmountWithdraw.Text);
                        accounts.Deposits(Session["CheckingAccountID"].ToString(), newBal);          //update accountSummary table
                        CRUD_Operations.Deposits(Convert.ToDateTime(lblDateW.Text), usrID, DDLWithdrawFrom.Text + " Withdraw",         //recording to transaction table
                             Convert.ToDouble("-" + txtAmountWithdraw.Text), Usr, DDLWithdrawDescrip.Text, Session["CheckingAccountID"].ToString(), newBal);
                        W1();
                        return;
                    }

                    else
                    {
                        lblMsg.Text = "Amount not succifienct!!"; lblMsg.ForeColor = Color.Red; txtAmountWithdraw.Focus();
                    }
                }
                else
                {
                    lblMsg.Text = "Create " + DDLWithdrawFrom.SelectedItem.Text + "First";
                }
                //for saving
                if (DDLWithdrawFrom.SelectedIndex == 2 && (Session["CheckingAccountID"] != null || Session["SavingAccountID"] != null || Session["CreditAccountID"] != null))
                {
                    bal = accounts.GetAccountBalance(Session["SavingAccountID"].ToString());                     //getting balance from account table
                                                                                                                 // bal = accounts.GetAccountBalance(Session["CheckingAccountID"].ToString());      //getting balance from account table
                    if (bal > amount)
                    {
                        double newBal = bal - Convert.ToDouble(txtAmountWithdraw.Text);
                        accounts.Deposits(Session["SavingAccountID"].ToString(), newBal);          //update accountSummary table
                        CRUD_Operations.Deposits(Convert.ToDateTime(lblDateW.Text), usrID, DDLWithdrawFrom.Text + " Withdraw",         //recording to transaction table
                             Convert.ToDouble("-" + txtAmountWithdraw.Text), Usr, DDLWithdrawDescrip.Text, Session["SavingAccountID"].ToString(), newBal);
                        W1();
                        return;
                    }
                    else
                    {
                        lblMsg.Text = "Amount not succifienct!!"; lblMsg.ForeColor = Color.Red; txtAmountWithdraw.Focus();
                    }
                }
                else
                {
                    lblMsg.Text = "Create " + DDLWithdrawFrom.SelectedItem.Text + "First";
                }

        }
            
            private void W1()
            {
            lblMsg.Text = "Withdraw Successfull!!"; lblMsg.ForeColor = Color.Green;
            BtnDeposit.Visible = true;
            BtnWithdraw.Visible = true;
            BtnTransfer.Visible = true;
            PanelWithdraw.Visible = false;
            txtAmountWithdraw.Text = string.Empty;
            DDLWithdrawDescrip.SelectedIndex = 0;
            DDLWithdrawFrom.SelectedIndex = 0;
            CheckUsrWithdraw.Checked = false;
            }

        protected void btnSubmitTransfer_Click(object sender, EventArgs e)
        {
            string Usr = null;
            if (CheckUsrDeposit.Checked)
            {
                Usr = "Cashier";
            }
            else
            {
                Usr = "Customer";
            }
            string usrID = Session["custid"].ToString();
            double bal = 0;
            //From Checking to Saving
            if (DDLTransFrom.SelectedIndex == 1 && DDLTransTo.SelectedIndex==2 && (Session["CheckingAccountID"] != null && Session["SavingAccountID"] != null))
            {
                //saving addition
                bal = accounts.GetAccountBalance(Session["SavingAccountID"].ToString());      //getting balance from account table
                double newBal = bal + Convert.ToDouble(txtAmountTransfer.Text);
                accounts.Deposits(Session["SavingAccountID"].ToString(), newBal);          //update accountSummary table
                CRUD_Operations.Deposits(Convert.ToDateTime(lblDateT.Text), usrID, "Received from checking",         //recording to transaction table
                     Convert.ToDouble(txtAmountTransfer.Text), Usr, "Online Transfer", Session["SavingAccountID"].ToString(), newBal);

                //checking deduction

                bal = accounts.GetAccountBalance(Session["CheckingAccountID"].ToString());      //getting balance from account table
                double newChkBal = bal - Convert.ToDouble(txtAmountTransfer.Text);
                accounts.Deposits(Session["CheckingAccountID"].ToString(), newChkBal);
                CRUD_Operations.Deposits(Convert.ToDateTime(lblDateT.Text), usrID, "Transfered to",         //recording to transaction table
                    Convert.ToDouble(txtAmountTransfer.Text), Usr, "Online Transfer", Session["CheckingAccountID"].ToString(), newChkBal);

                T1();
                return;
            }
            else
            {
                lblMsg.Text = "You have choosed same Account!! Please Select Different Account!!";
                lblMsg.ForeColor = Color.Red;
            }
            //for saving to checking
            if (DDLTransFrom.SelectedIndex == 2 && DDLTransTo.SelectedIndex==1 && (Session["CheckingAccountID"] != null && Session["SavingAccountID"] != null))
            {
                //checking addition
                bal = accounts.GetAccountBalance(Session["CheckingAccountID"].ToString());
                double newBal = bal + Convert.ToDouble(txtAmountTransfer.Text);
                accounts.Deposits(Session["CheckingAccountID"].ToString(), newBal);          //update accountSummary table
                CRUD_Operations.Deposits(Convert.ToDateTime(lblDateT.Text), usrID, "Received from Saving",         //recording to transaction table
                     Convert.ToDouble(txtAmountTransfer.Text), Usr, "Online Transfer", Session["CheckingAccountID"].ToString(), newBal);

                //saving deduction

                bal = accounts.GetAccountBalance(Session["SavingAccountID"].ToString());      //getting balance from account table
                double newSvBal = bal - Convert.ToDouble(txtAmountTransfer.Text);
                accounts.Deposits(Session["SavingAccountID"].ToString(), newSvBal);
                CRUD_Operations.Deposits(Convert.ToDateTime(lblDateT.Text), usrID, "Transfered to",         //recording to transaction table
                    Convert.ToDouble(txtAmountTransfer.Text), Usr, "Online Transfer", Session["SavingAccountID"].ToString(), newSvBal);

                T1();
                return;
            }
            else
            {
                lblMsg.Text = "You have choosed same Account!! Please Select Different Account!!";
                lblMsg.ForeColor = Color.Red;
            }
        }
        private void T1() {
            lblMsg.Text = "Transfer Successfull!!"; lblMsg.ForeColor = Color.Green;
            txtAmountTransfer.Text = "";
            DDLTransFrom.SelectedIndex = 0;
            DDLTransTo.SelectedIndex = 0;
            PanelTransfer.Visible = false;
            BtnDeposit.Visible = true;
            BtnWithdraw.Visible = true;
            BtnTransfer.Visible = true;

        }
    }
}