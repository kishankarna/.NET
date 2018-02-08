using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ADO.NET.querystring
{
    public partial class form2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sname = Request.QueryString["name"];
            string saddress = Request.QueryString["address"];
            lblNameResult.Text = sname;
            lblResultAdd.Text = saddress;

        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("form1.aspx");
        }
    }
}