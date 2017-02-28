using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_PageLifeCycle
{
    public partial class Navigation : System.Web.UI.Page
    {
        public int S
        {
            get;
            set;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            S = 100;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //SECOND PARAMETER INFORMS TO PRESERVE CALLING FORM OBJECT
            Server.Transfer("Navigation2.aspx", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Execute("Navigation2.aspx");
        }
    }
}