using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_PageLifeCycle
{
    public partial class Navigation2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Navigation nevpage = (Navigation) PreviousPage;
            if (nevpage != null)
            {
                int p = nevpage.S;
                Response.Write(p.ToString());
            }

            
        }
    }
}