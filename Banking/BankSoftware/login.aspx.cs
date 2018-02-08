using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Security.Cryptography;
using System.Web.Security;
using System.Configuration;
using System.Text;
namespace BankSoftware
{
    public partial class customerLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                txtUsr.Focus();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
          


            try
            {
                DataTable data = new DataTable();
                var encryptPwd=string.Empty;
                if (txtPass.Text != String.Empty && txtUsr.Text != String.Empty)
                {
                    //MD5 hashing   
                    encryptPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPass.Text, "MD5");
                }
                else { lblMsg.Text = "Please provide user id and password!!"; lblMsg.ForeColor = System.Drawing.Color.Red; }
                //*********************************************
                data = BusinessLayer.UserAccess.GetCustomerPasswords(txtUsr.Text);
                string pass = string.Empty; string account = string.Empty;
                if (data != null)
                {
                    pass = data.Rows[0]["password"].ToString();

                    account = data.Rows[0]["accountID"].ToString();
                }

                if (pass ==encryptPwd )

                {
                    Session["name"] = txtUsr.Text;
                    Session["account"] = account;
                 
                    FormsAuthentication.RedirectFromLoginPage(txtUsr.Text, true);

                }
                else
                {
                    lblMsg.Text = "Invalid User name / or Password!!";
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                }

            } catch (Exception ex)
            { lblMsg.Text = "Error!!, Try again!!";lblMsg.ForeColor = System.Drawing.Color.Red; }
        }


    }
}