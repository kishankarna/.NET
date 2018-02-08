using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ASP.NET_Server_Controls.FileUpload
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                lbl.Text = "File is uploaded!!";
                lbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbl.Text = "Please select file to upload!!";
                lbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btn2Upload_Click(object sender, EventArgs e)
        {
            if (FileUpload2.HasFile)
            {
                string fileExt = System.IO.Path.GetExtension(FileUpload2.FileName);
                if (fileExt.ToLower()!=".doc" && fileExt.ToLower()!=".docx")
                {
                    lblMessage.Text = "Please select .doc or .docx Files only!!, Warning!!";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int fileSize = FileUpload2.PostedFile.ContentLength;
                    if (fileSize > 2097152)
                    {
                        lblMessage.Text = "File is maximum than 2MB!!";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                       // FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                        FileUpload2.SaveAs(Server.MapPath("~/Uploads/" + FileUpload2.FileName));
                        lblMessage.Text = "File is uploaded!!";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            else
            {
                lblMessage.Text = "Please Select file to upload!!"; lbl.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}