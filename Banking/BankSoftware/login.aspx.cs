using System;
using System.Web.UI;
//using System.Security.Cryptography;
using System.Web.Security;
using System.Collections.Generic;

namespace BankSoftware
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                txtUsr.Focus();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {


            if (txtPass.Text == string.Empty && txtUsr.Text == string.Empty)
            {
                lblMsg.Text = "Provie Login info";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                try
                {
                    // DataTable data = new DataTable();
                    List<string> data = new List<string>();
                    var encryptPwd = string.Empty;
                    if (txtPass.Text != String.Empty && txtUsr.Text != String.Empty)
                    {
                        //MD5 hashing   
                        encryptPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPass.Text, "MD5");
                    }
                    else { lblMsg.Text = "Please provide user id and password!!"; lblMsg.ForeColor = System.Drawing.Color.Red; }
                    //*********************************************
                    data = BusinessLayer.UserAccess.GetCustomerPasswords(txtUsr.Text);
                    string pass = string.Empty; string name = string.Empty;
                    if (data != null)
                    {
                        pass = data[0];

                        name = data[1];
                    }

                    if (pass == encryptPwd && pass!=string.Empty)

                    {
                        Session["name"] = name;
                        Session["custid"] = txtUsr.Text;

                        FormsAuthentication.RedirectFromLoginPage(txtUsr.Text, true);

                    }
                    else
                    {
                        lblMsg.Text = "Invalid User name / or Password!!";
                        lblMsg.ForeColor = System.Drawing.Color.Red;
                    }

                }
                catch (Exception ex)
                { lblMsg.Text = "Error!!, Try again!!"; lblMsg.ForeColor = System.Drawing.Color.Red; }
            }
        }

    }
}