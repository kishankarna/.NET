using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.StateManagement.ViewState.exmp2
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack) {

                TextBox1.Text = "0";
                ViewState["count"] = 0;
               
            }

            
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            ViewState["count"] = Convert.ToInt32(ViewState["count"]) + 1;
            TextBox1.Text = ViewState["count"].ToString();
        }
    }
}