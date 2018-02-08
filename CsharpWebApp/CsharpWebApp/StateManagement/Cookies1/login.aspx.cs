using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.StateManagement.Cookies1
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLog_Click(object sender, EventArgs e)
        {

            Session["name"] = txtName.Text;

            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["name"] = txtName.Text;      

            //if you dont giver expire property then it is non persitent cookie, which wont be stored!!

            cookie.Expires = DateTime.Now.AddDays(2);       //cokkie stays for 2 days
            Response.Cookies.Add(cookie);                   //adding cookie

            Response.Redirect("dashBoard.aspx");
        }
    }
}