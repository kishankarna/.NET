using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CsharpWebApp.ASP.NET_Server_Controls.panelcontorl2
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            
        
        }

        protected void btnLabl_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = "This is label";
            Panel1.Controls.Add(lbl);

        }

        protected void btnCreateTxt_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            txt.Text = "Karna";
            Panel1.Controls.Add(txt);
        }
    }
}