using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationUsing_LINQ.GridView
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {


            string[] names = { "Karna", "Nikson", "Nanu", "Hari", "Ram" };

            GridView1.DataSource = from name in names
                                   where name == "Karna"
                                   select name;
            GridView1.DataBind();


        }
    }
}