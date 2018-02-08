using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.sendingEmail
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify the from and to email address
                MailMessage mailMessage = new MailMessage(txtFrom.Text, txtTo.Text);
                // Specify the email body
                mailMessage.Body = txtBody.Text;
                // Specify the email Subject
                mailMessage.Subject = txtSubj.Text;

                // No need to specify the SMTP settings as these 
                // are already specified in web.config
                SmtpClient smtpClient = new SmtpClient();
                // Finall send the email message using Send() method
                smtpClient.Send(mailMessage);

                lblMsg.Text = "E-mail sended";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                txtBody.Text = txtFrom.Text = txtSubj.Text = txtTo.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error while sending E-mail!!";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}