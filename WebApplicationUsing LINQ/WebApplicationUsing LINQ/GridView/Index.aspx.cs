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

        int[] numarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25 };
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {


            string[] names = { "Karna", "Nikson", "Nanu", "Hari", "Ram" };

            GridView1.DataSource = from name in names
                                   where name != "Hari"
                                   select name;
            GridView1.DataBind();


        }

        protected void btnEven_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = from num in numarray
                                   where (num % 2 == 0)
                                   select num;


            GridView1.DataBind();
        }

        protected void btnOdd_Click(object sender, EventArgs e)
        {

            GridView1.DataSource = from num in numarray
                                   where (num % 2 != 0)
                                   select num;
            GridView1.DataBind();
        }
    }
}