using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _004_StateManagement
{
    public partial class disableviewstate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //STEP1: Observe aspx file EnableViewState is set to false
            //STEP2: Even if EnableViewState is false, the page might contain a hidden view state field that is used by ASP.NET to detect a postback.
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}