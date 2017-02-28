using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_PageLifeCycle
{
    public partial class TestPage2 : System.Web.UI.Page
    {
        //Observe aspx file using the resource file, introducing concept of resource file
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = App_GlobalResources.Resource1.Hello;
            Response.Write(s);
        }
    }
}