using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _005_POSTBACKTEST
{
    public partial class testform1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.Write("hello");
            }
            else
            {
                Response.Write("bye");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<b> hjhjksdhfjsh </b>");
        }
    }
}