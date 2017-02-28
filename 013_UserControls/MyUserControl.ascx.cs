using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _013_UserControls
{
    public partial class MyUserControl : System.Web.UI.UserControl
    {
        public Color FColor { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.ForeColor = FColor;
            Label1.Text = "Hello";

        }
    }
}