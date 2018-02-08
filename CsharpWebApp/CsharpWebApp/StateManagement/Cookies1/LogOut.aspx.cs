using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.StateManagement.Cookies1
{
    public partial class LogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Session.Abandon();              //killing Session

                HttpCookie ck = Request.Cookies["UserInfo"]; //for cookie killing
                ck.Expires = DateTime.Now.AddDays(-1);  //to kill cookie
                Response.Cookies.Add(ck);               //killing cookie added
                lgOut.Text = "Successfull logout!!";
            }
            catch (Exception ex) { Response.Write (ex.Message); }
        }
    }
}