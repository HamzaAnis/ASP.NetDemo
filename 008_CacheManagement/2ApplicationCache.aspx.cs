using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _008_CacheManagement
{
    public partial class _2ApplicationCache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["X"] == null)
            {
                //Either not created or removed form the cache
                //Recalculate or get from database - webservice etc
                Cache["X"] = 100; //You can store any value or ref type
            }
            
                Response.Write(Cache["X"].ToString());
            
        }
    }
}