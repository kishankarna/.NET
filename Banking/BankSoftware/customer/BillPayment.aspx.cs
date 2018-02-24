using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Web.UI;
using BusinessLayer;

namespace BankSoftware.customer
{
    public partial class BillPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!Page.IsPostBack)
            {
                lblUsr.Text = "Welcome : " + Session["name"].ToString();
                lblUsr.ForeColor = Color.Green;
                //for  options
                if (Session["CheckingAccountID"] != null)
                {
                    DDLpaymentFrom.Items.Add("Checking");
                    
                }
                if (Session["SavingAccountID"] != null)
                {
                    DDLpaymentFrom.Items.Add("Saving");

                }
                if (Session["CreditAccountID"] != null)
                {
                    DDLpaymentTo.Items.Add("Credit");
                }

               TxtCustID.Text = Session["custid"].ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string usrID = Session["custid"].ToString();
            double creditbal = 0;
            
            double accountbalance = 0;
            string date = DateTime.Now.ToShortDateString();
            //
            if (DDLpaymentTo.SelectedIndex == 1 && Session["CreditAccountID"] != null)
            {
                if (DDLpaymentFrom.SelectedIndex == 1 && (Session["CheckingAccountID"] != null))
                {
                    //for credit
                    creditbal = creditOperation.AccountBalance(Session["CreditAccountID"].ToString());      //getting balance from accountsummary table
                    double newBal = creditbal + Convert.ToDouble(txtAmount.Text);
                    if (newBal > 500) //checking payment amount
                    { lblMsg.Text = "The amount provided is more than payment required / payment not required!!";
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                    accounts.Deposits(Session["CreditAccountID"].ToString(), newBal);          //update accountSummary table
                    CRUD_Operations.Deposits(Convert.ToDateTime(date) , usrID, "Received Payment",         //recording to transaction table
                         Convert.ToDouble(txtAmount.Text), "Self/Customer", "Online", Session["CreditAccountID"].ToString(), newBal);

                    //for checking account update
                    accountbalance = creditOperation.AccountBalance(Session["CheckingAccountID"].ToString());
                    double newChkBal = accountbalance - Convert.ToDouble(txtAmount.Text);
                    accounts.Deposits(Session["CheckingAccountID"].ToString(), newChkBal);          //update accountSummary table
                    CRUD_Operations.Deposits(Convert.ToDateTime(date), usrID, "Credit Card Payment",         //recording to transaction table
                         Convert.ToDouble(txtAmount.Text), "Self/Customer", "Online", Session["CheckingAccountID"].ToString(), newChkBal);

                    clear();
                    lblMsg.Text = "Payment Successfull!!";
                    lblMsg.ForeColor = Color.Green;
                    return;
                }

                if (DDLpaymentFrom.SelectedIndex == 2 && (Session["SavingAccountID"] != null))
                {
                    //for credit
                    creditbal = creditOperation.AccountBalance(Session["CreditAccountID"].ToString());      //getting balance from accountsummary table
                    double newBal = creditbal + Convert.ToDouble(txtAmount.Text);
                    if (newBal > 500)  //checking payment amount
                    {
                        lblMsg.Text = "The amount provided is more than payment required / payment not required!!";
                        lblMsg.ForeColor = Color.Red;
                        return;
                    }
                    accounts.Deposits(Session["CreditAccountID"].ToString(), newBal);          //update accountSummary table
                    CRUD_Operations.Deposits(Convert.ToDateTime(date), usrID, "Received Payment",         //recording to transaction table
                         Convert.ToDouble(txtAmount.Text), "Self/Customer", "Online", Session["CreditAccountID"].ToString(), newBal);

                    //for saving account update
                    accountbalance = creditOperation.AccountBalance(Session["SavingAccountID"].ToString());
                    double newSvBal = accountbalance - Convert.ToDouble(txtAmount.Text);
                    accounts.Deposits(Session["SavingAccountID"].ToString(), newSvBal);          //update accountSummary table
                    CRUD_Operations.Deposits(Convert.ToDateTime(date), usrID, "Credit Card Payment",         //recording to transaction table
                         Convert.ToDouble(txtAmount.Text), "Self/Customer", "Online", Session["SavingAccountID"].ToString(), newSvBal);


                    clear();
                    lblMsg.Text = "Payment Successfull!!";
                    lblMsg.ForeColor = Color.Green;
                    return;
                }


            }
            else
            {
                lblMsg.Text = "You don't need to make any payment as of now";
            }

        }

        private void clear() {
            txtAmount.Text = string.Empty;
            DDLpaymentFrom.SelectedIndex = 0;
            DDLpaymentTo.SelectedIndex = 0;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}