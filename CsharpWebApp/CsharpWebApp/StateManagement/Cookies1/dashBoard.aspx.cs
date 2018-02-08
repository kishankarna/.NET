using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.StateManagement.Cookies1
{
    public partial class dashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie ck = Request.Cookies["UserInfo"];
            string uname = string.Empty;

            if (Session["name"] != null || ck != null)
            {
                if (Session["name"] != null)
                {
                    uname = Session["name"].ToString();
                    lblUser.Text = "Welcome " + uname;
                    lblUser.Text += ", your are logged in with the sesion";
                    lblUser.ForeColor = System.Drawing.Color.Green;
                }
                else
                {

                    Session["name"] = ck["name"];
                    if (ck != null)
                    {
                        lblUser.Text = "Welcome " + ck["name"];
                        lblUser.Text += ", your are logged in with the Cookie";
                        lblUser.ForeColor = System.Drawing.Color.Blue;
                    }

                }
            }
            else { lblUser.Text = "Please Login First!!"; lblUser.ForeColor = System.Drawing.Color.Red; }

        }
    }
}
