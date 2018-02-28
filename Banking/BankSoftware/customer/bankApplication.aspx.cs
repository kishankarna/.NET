using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using BusinessLayer;
using System.Web.UI.WebControls;

namespace BankSoftware.bank
{
    public partial class bankApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsr.Text = "Current User : " + Session["name"].ToString();
            if (!IsPostBack)
            {
                if (Session["CheckingAccountID"] != null)
                {
                    lblCheck.Text = "$" + Convert.ToString(checkingOperation.AccountBalance(Session["CheckingAccountID"].ToString()));
                    DDLLstMnth.Items.Add("Checking");
                    DDL2LstMnth.Items.Add("Checking");
                    DDL3rdLstMnth.Items.Add("Checking");
                }
                if (Session["SavingAccountID"] != null)
                {
                    lblSaving.Text = "$" + Convert.ToString(checkingOperation.AccountBalance(Session["SavingAccountID"].ToString()));
                    DDLLstMnth.Items.Add("Saving");
                    DDL2LstMnth.Items.Add("Saving");
                    DDL3rdLstMnth.Items.Add("Saving");
                }
                if (Session["CreditAccountID"] != null)
                {
                    lblCredit.Text = "$" + Convert.ToString(checkingOperation.AccountBalance(Session["CreditAccountID"].ToString()));
                    DDLLstMnth.Items.Add("Credit");
                    DDL2LstMnth.Items.Add("Credit");
                    DDL3rdLstMnth.Items.Add("Credit");
                }

            }
            LstMonth.Text = DateTime.Now.AddMonths(-1).ToString("MMMM");
            HiddenField1.Value= DateTime.Now.AddMonths(-1).ToString("MM");
            Lst2Mnth.Text = DateTime.Now.AddMonths(-2).ToString("MMMM");
            HiddenField2.Value = DateTime.Now.AddMonths(-2).ToString("MM");
            Lst3rdMnth.Text = DateTime.Now.AddMonths(-3).ToString("MMMM");
            HiddenField3.Value = DateTime.Now.AddMonths(-3).ToString("MM");

        }

        protected void btn1Month_Click(object sender, EventArgs e)
        {
            
            if (DDLLstMnth.SelectedItem.Text == "Checking")
            {
                GridView1.DataSource = accounts.StatementsByMonth(HiddenField1.Value, Session["CheckingAccountID"].ToString());
                GridView1.DataBind();
                GeneratePDF(LstMonth.Text);
            }

            else if (DDLLstMnth.SelectedItem.Text == "Saving")
            {
                GridView1.DataSource = accounts.StatementsByMonth(HiddenField1.Value, Session["SavingAccountID"].ToString());
                GridView1.DataBind();
                GeneratePDF(LstMonth.Text );
            }
            else if (DDLLstMnth.SelectedItem.Text == "Credit")
            {
                GridView1.DataSource = accounts.StatementsByMonth(HiddenField1.Value, Session["CreditAccountID"].ToString());
                GridView1.DataBind();
                GeneratePDF(LstMonth.Text);
            }

        }

        protected void btn2Month_Click(object sender, EventArgs e)
        {
           
            if (DDL2LstMnth.SelectedItem.Text == "Checking")
            {
                GridView1.DataSource = accounts.StatementsByMonth(HiddenField2.Value, Session["CheckingAccountID"].ToString());
                GridView1.DataBind();
                GeneratePDF(Lst2Mnth.Text);
            }
            else if (DDL2LstMnth.SelectedItem.Text == "Saving")
            {
                GridView1.DataSource = accounts.StatementsByMonth(HiddenField2.Value, Session["SavingAccountID"].ToString());
                GridView1.DataBind();
                GeneratePDF(Lst2Mnth.Text);
            }
            else if (DDL2LstMnth.SelectedItem.Text == "Credit")
            {
                GridView1.DataSource = accounts.StatementsByMonth(HiddenField2.Value, Session["CreditAccountID"].ToString());
                GridView1.DataBind();
                GeneratePDF(Lst2Mnth.Text);
            }

        }
        
        protected void btn3Month_Click(object sender, EventArgs e)
        {
            if (DDL3rdLstMnth.SelectedItem.Text == "Checking")
            {
                GridView1.DataSource = accounts.StatementsByMonth(HiddenField3.Value, Session["CheckingAccountID"].ToString());
                GridView1.DataBind();
                GeneratePDF(Lst3rdMnth.Text);
            }
            else if (DDL3rdLstMnth.SelectedItem.Text == "Saving")
            {
                GridView1.DataSource = accounts.StatementsByMonth(HiddenField3.Value, Session["SavingAccountID"].ToString());
                GridView1.DataBind();
                GeneratePDF(Lst3rdMnth.Text);
            }
            else if (DDL3rdLstMnth.SelectedItem.Text == "Credit")
            {
                GridView1.DataSource = accounts.StatementsByMonth(HiddenField3.Value, Session["CreditAccountID"].ToString());
                GridView1.DataBind();
                GeneratePDF(Lst3rdMnth.Text);
            }
        }
        private void GeneratePDF(string month)
        {
            try
            {

                int columnsCount = GridView1.HeaderRow.Cells.Count;
                // Create the PDF Table specifying the number of columns
                PdfPTable pdfTable = new PdfPTable(columnsCount);

                pdfTable.SpacingBefore = 20; //for spacing
                // Loop thru each cell in GrdiView header row
                foreach (TableCell gridViewHeaderCell in GridView1.HeaderRow.Cells)
                {
                    // Create the Font Object for PDF document
                    Font font = new Font();
                    // Set the font color to GridView header row font color
                    font.Color = new BaseColor(GridView1.HeaderStyle.ForeColor);

                    // Create the PDF cell, specifying the text and font
                    PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewHeaderCell.Text, font));

                    // Set the PDF cell backgroundcolor to GridView header row BackgroundColor color
                    pdfCell.BackgroundColor = new BaseColor(GridView1.HeaderStyle.BackColor);

                    // Add the cell to PDF table
                    pdfTable.AddCell(pdfCell.Phrase.Content.ToString());
                }

                // Loop thru each datarow in GrdiView
                foreach (GridViewRow gridViewRow in GridView1.Rows)
                {
                    //if (gridViewRow.RowType == DataControlRowType.DataRow)
                    //{
                    // Loop thru each cell in GrdiView data row
                    foreach (TableCell gridViewCell in gridViewRow.Cells)
                    {
                        Font font = new Font();
                        font.Color = new BaseColor(GridView1.RowStyle.ForeColor);

                        PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewCell.Text, font));

                        pdfCell.BackgroundColor = new BaseColor(GridView1.RowStyle.BackColor);

                        pdfTable.AddCell(pdfCell.Phrase.Content.ToString());
                    }
                    //}
                }

                // Create the PDF document specifying page size and margins
                Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

                PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

                //title for pdf
                var titleFont = FontFactory.GetFont("Arial", 14, Font.BOLDITALIC);
                var emailFont = FontFactory.GetFont("Arial", 13, Font.ITALIC);
                // Create Header in PDF file"
                var h1 = new Paragraph("United Local Bank",titleFont);
                var h2 = new Paragraph("Euless, TX",titleFont);
                var h3 = new Paragraph("Email: kisanthapamagar@gmail.com",emailFont);
                
                
                pdfDocument.Open();
                pdfDocument.Add(h1);
                pdfDocument.Add(h2);
                pdfDocument.Add(h3);
                pdfDocument.Add(pdfTable);
                pdfDocument.Close();

                Response.ContentType = "application/pdf";
                Response.AppendHeader("content-disposition",
                    string.Format("attachment;filename=Report-{0}.pdf",month));
                Response.Write(pdfDocument);
                Response.Flush();
               // Response.End();       //ignore this so it wont jump to excepttion even though everything is correct
               
            }
            catch (Exception ex)
            {

                Msg2.Text = "There is no data to Generate!!";
                Msg2.ForeColor = System.Drawing.Color.Red;
                Console.WriteLine(ex);
            }
        }

    }
}

      
    
