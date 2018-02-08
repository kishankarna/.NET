
using CsharpWebApp.CustomExceptionEventViewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace CsharpWebApp
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Create Application state variables
            Application["TotalApplications"] = 0;
            Application["TotalUserSessions"] = 0;
            // Increment TotalApplications by 1
            Application["TotalApplications"] = (int)Application["TotalApplications"] + 1;
        }
        void Session_Start(object sender, EventArgs e)
        {
            // Increment TotalUserSessions by 1C:\Users\Nikson\source\repos\CsharpWebApp\CsharpWebApp\StateManagement\querystring\
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] + 1;
        }
        void Session_End(object sender, EventArgs e)
        {
            // Decrement TotalUserSessions by 1
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] - 1;
        }
        void Application_Error(object sender, EventArgs e)
        {
            //Exception ex = Server.GetLastError();

            //this  is for loggin exception
            if (Server.GetLastError() != null)
            {
                // Get and Log the exception
                Logger.Log(Server.GetLastError());
                // Clear the exception
                Server.ClearError();
                // Transfer the user to Errors.aspx page
                Server.Transfer("~/ErrorHandlinginASP.NET/error.aspx");
            }


            //this is for application error handling
            //// Get the exception details and log it in the database or event viewer
            //Exception ex = Server.GetLastError();
            //// Clear the exception
            //Server.ClearError();
            //// Redirect user to Error page
            //Response.Redirect("~/ErrorHandlinginASP.NET/error.aspx");
        }

    }
}