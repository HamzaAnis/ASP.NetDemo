using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_PageLifeCycle
{
    //TESTING THE POSTBACK CONCEPT
    public partial class TestPage3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("<br> Rendering for the first Time");
            }
            else
            {
                Response.Write("<br> It is a post back ");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<br> Button Handler called");
        }
    }
}