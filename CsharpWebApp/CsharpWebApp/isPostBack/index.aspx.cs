using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.isPostBack
{
    public partial class index : System.Web.UI.Page
    {
        protected void btnClick_Click(object sender, EventArgs e)
        {
           
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DrpLoad();
            }
        }
        void DrpLoad() {

            DropDownList1.Items.Add("Select");
            DropDownList1.Items.Add("USA");
            DropDownList1.Items.Add("Nepal");
        }

    }
}