using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003_PageLifeCycle
{
    public partial class TestPage1 : System.Web.UI.Page
    {
        string s = " Some data";
        

        //ACCESS THIS DATA IN ASPX PAGE - OBSERVE TestPage1.aspx
        public string S
        {
            get { return s; }
            set { s = value; }
        }

        protected void Page_Init(object source, EventArgs e)
        {


        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
                   
            Response.Write("<p><b> Inserted text html .... </b></p>");
            
        }
        
        
        
    }
}