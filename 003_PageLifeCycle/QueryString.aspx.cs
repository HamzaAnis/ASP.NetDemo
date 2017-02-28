using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_PageLifeCycle
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string X = Request.QueryString["x"];
            string Y = Request.QueryString["y"];
            string Z = Request.QueryString["z"];

            Response.Write("x=" + X+ "<br>");
            Response.Write("y=" + Y + "<br>");
            Response.Write("z=" + Z + "<br>");


        }
    }
}