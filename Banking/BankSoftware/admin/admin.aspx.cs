using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankSoftware.admin
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      

            protected void btnDisplay_Click(object sender, EventArgs e)
        {
            lblUsr.Text = Application["UsersOnline"].ToString();
        }
    }
}