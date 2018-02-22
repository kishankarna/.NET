using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Http;
    

namespace WebServiceConsumption
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            ServiceReference1.SampleWebserviceSoapClient client = new ServiceReference1.SampleWebserviceSoapClient();

            if (DDLOperation.SelectedValue !="-1")
            {
                string result = client.calculation(
                    Convert.ToInt32(txtFirstValue.Text),
                    Convert.ToInt32(txtSecondValue.Text),
                    DDLOperation.SelectedValue);

                lblResult.Text = result;
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResult.Text = "Select an Operation to Perform!!";
                lblResult.ForeColor = System.Drawing.Color.Red;

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}