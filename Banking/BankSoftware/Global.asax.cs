using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BankSoftware
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs when the application starts
            Application["UsersOnline"] = 0;

        }

        protected void Session_Start(object sender, EventArgs e)
        {

            // Code that runs when a new user session is started
            Application.Lock();
            Application["UsersOnline"] = (int)Application["UsersOnline"] + 1;
            Application.UnLock();


        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            
                // Get the exception details and log it in the database or event viewer
                Exception ex = Server.GetLastError();
                // Clear the exception
               Server.ClearError();
                // Redirect user to Error page
                Server.Transfer("~/errors/errorPage.aspx");
                //Response.Redirect("~/errors/errorPage.aspx");

        }

            protected void Session_End(object sender, EventArgs e)
        {
            // Code that runs when an existing user session ends. 
            Application.Lock();
            Application["UsersOnline"] = (int)Application["UsersOnline"] - 1;
           
            Application.UnLock();

        }

        protected void Application_End(object sender, EventArgs e)
        {
            // Code that runs whe

        }
    }
}