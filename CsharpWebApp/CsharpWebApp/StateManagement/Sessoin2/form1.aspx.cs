using System;
using System.Collections;
using System.Drawing;

namespace CsharpWebApp.StateManagement.Sessoin2
{
    public partial class form1 : System.Web.UI.Page
    {
        
        public bool AuthenticateUser(string name, string pass)
        {
            bool sFlag = false;
            Hashtable user = new Hashtable();

            user.Add("karna", "karna1");
            user.Add("nanu", "nanu1");
            user.Add("nikson", "ninkson1");

            if (user.Contains(name))
            {
                if (user[name].ToString() == pass)
                {

                    sFlag = true;
                }

            }
            
            return sFlag;
          
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
           

           if( AuthenticateUser(txtName.Text,txtPassword.Text ))
            {
                //lbl.Text = "Congratulations!!";
                //lbl.ForeColor = Color.Green;
                Session["user"] = txtName.Text;
                Response.Redirect("form2.aspx");
            }
            else {
                lbl.Text = "Not Valid Credential!!";
                lbl.ForeColor = Color.Red;
            }
       
        }
    }
}