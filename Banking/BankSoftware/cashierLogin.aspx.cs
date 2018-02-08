using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.Security;

namespace BankSoftware
{
    public partial class cashierLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUsr.Focus();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //md5 hashing   //ram has ram1 password

            var hash_pass = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPass.Text, "MD5");
            //*********************************************
            string pass = BusinessLayer.UserAccess.GetCashierPasswords(txtUsr.Text);
            if (pass == hash_pass)

            {
                Session["name"] = txtUsr.Text;
                // Response.Redirect("bankApplication.aspx");
                FormsAuthentication.RedirectFromLoginPage(txtUsr.Text, false);
            }
            else
            {
                lblMsg.Text = "Invalid password!!";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}