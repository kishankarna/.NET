using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ASP.NET_Server_Controls.addRotator
{
    public partial class ad2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AdRotator1.KeywordFilter = "google";
        }
    }
}