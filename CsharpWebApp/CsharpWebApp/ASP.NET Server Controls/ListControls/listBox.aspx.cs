using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CsharpWebApp.ListControls
{
    public partial class listBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            BulletedList1.Items.Clear();
            CheckBoxList1.Items.Clear();
            DropDownList1.Items.Clear();
            ListBox1.Items.Clear();
            RadioButtonList1.Items.Clear();

            string[] name = { "Karna", "Nikson", "Nanu", "Jeevan" };
            for(int i=0;i<name.Length;i++)
                BulletedList1.Items.Add(name[i]);

            List<string> car = new List<string>() ;
            car.Add("Honda");
            car.Add("Corolla");
            car.Add("Cadillac");
            car.Add("Mercedez");
            foreach (string cars in car)
                CheckBoxList1.Items.Add(cars);

            DropDownList1.DataSource = new string[] { "JAVA", "c#.NET", "Angular", "Python" };
            DropDownList1.DataBind();

            List<String> month = new List<string>() { "January","Februay","March","April","May"};
            foreach (string months in month)
                ListBox1.Items.Add(months);
            RadioButtonList1.DataSource = new int[] { 2000, 2001, 2002, 2003, 2004 };
            RadioButtonList1.DataBind();

            Label1.Text = BulletedList1.Items.Count.ToString();

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            BulletedList1.Items.Clear();
            CheckBoxList1.Items.Clear();
            DropDownList1.Items.Clear();
            ListBox1.Items.Clear();
            RadioButtonList1.Items.Clear();
        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue; 
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = RadioButtonList1.SelectedValue; 
        }
    }
}