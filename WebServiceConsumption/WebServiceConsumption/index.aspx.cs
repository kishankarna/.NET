using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            string result = client.calculation(
                Convert.ToInt32(txtFirstValue.Text), 
                Convert.ToInt32(txtSecondValue.Text), 
                txtOperation.Text);

            lblResult.Text = result;

        }
    }
}