using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ASP.NET_Server_Controls.MultiView
{
    public partial class indexz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                MultiView1.ActiveViewIndex = 0;
            } 
        }

      

        protected void btn1Next_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btn2Next_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
            //retrieve data in final session:
            lblFirstName.Text = txtFirstName.Text;
            lblLast.Text = txtLastName.Text;
            if (rdFemale.Checked)
                lblGender.Text = "Female";
            else if (rdMale.Checked)
                lblGender.Text = "Male";
            lblAdd.Text = txtAdd.Text;
            lblEmai.Text = txtEmail.Text;
            lblPhn.Text = txtPhn.Text ;
        }

        protected void btn1Previous_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void btn2Previous_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
           

        }
    }
}