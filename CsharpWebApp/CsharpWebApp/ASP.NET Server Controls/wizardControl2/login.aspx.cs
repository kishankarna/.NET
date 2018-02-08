using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ASP.NET_Server_Controls.wizardControl2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            bool val = UsrAuthenticate(TxtUsr.Text, TxtPwd.Text);
            if (val == true)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                Lbl.Text = "Not Valid Credentials!!";
                Lbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        bool UsrAuthenticate(string usr,string pwd)
        {
            //usr = TxtUsr.Text;
            //pwd = TxtPwd.Text;
            if (usr == "karna" && pwd == "niksonbaby")
                return true;
            else
                return false;
        }
    }
}