using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _004_StateManagement
{
    public partial class GetSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Getting unique identifier for your session ID
            Response.Write(Session.SessionID.ToString());
        }
    }
}