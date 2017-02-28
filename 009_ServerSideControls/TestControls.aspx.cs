using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _009_ServerSideControls
{
    public partial class TestControls : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //working with hidden field
            HiddenField1.Value = "hello";

            
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Autopost back set to true for this control
            TextBox1.Text = CheckBox1.Checked.ToString();
            
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = CheckBoxList1.Items[0].Selected.ToString();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = ListBox1.SelectedItem.ToString();
            
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        }
    }
}