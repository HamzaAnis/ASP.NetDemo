using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _004_StateManagement
{
    public partial class Start : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Session State
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["k"] == null) ViewState["k"] = 0;  
            ViewState["k"] = (int)ViewState["k"] + 1;
            Label1.Text = ViewState["k"].ToString();
        }

        /// <summary>
        /// View State
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            //Boxing unboxing concept
            //Initialized in Global.asax
            Session["j"] = (int) Session["j"] + 1;
            Label2.Text = Session["j"].ToString();
           
        }

        /// <summary>
        /// Application State
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button3_Click(object sender, EventArgs e)
        {
            Application["i"] = (int)Application["i"] + 1;
            Label3.Text = Application["i"].ToString();
            
        }
    }
}