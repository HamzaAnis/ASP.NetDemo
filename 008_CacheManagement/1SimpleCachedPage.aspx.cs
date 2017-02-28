using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _008_CacheManagement
{
    public partial class _1SimpleCachedPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Observe OutputCache directive in aspx page
            //This will not  be called if served using output cache
            Session["x"] = (int)Session["x"] + 1;
            TextBox1.Text= Session["x"].ToString();
           
          
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}