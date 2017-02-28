using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _011_DataBindingConcept
{
    public partial class _1BindDropdownlist : System.Web.UI.Page
    {
        public string[] arrData = new string[] { "Lahore", "Karachi", "Islamabad", "Peshawar" };

        protected void Page_Load(object sender, EventArgs e)
        {
            //Binding drop down list declaratively

            //binding List 
            ListBox1.DataSource = arrData;
            Page.DataBind();
        }
    }
}