using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
namespace CsharpWebApp.CustomExceptionEventViewer
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // DataSet is System.Data namespace
            DataSet ds = new DataSet();
            // This line throws FileNotFoundException
            ds.ReadXml(Server.MapPath("~/Data/Countries.xml"));

            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // System.Diagnostics.EventLog.CreateEventSource("karna event", "karna Application");
        }
    }
}