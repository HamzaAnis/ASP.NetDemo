using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _007_CookiesForStateManagement
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HTML5 offers better alternate 
            //JUST TESTING COOKIES; SET or READ COOKIE
            HttpCookie CookieRef;
            if (!Page.IsPostBack)//is it the first time
                if (Request.Browser.Cookies)
                {
                    CookieRef = Request.Cookies["MyCookie"];
                    if (CookieRef == null)
                    {
                        //HttpCookie cookie = new HttpCookie("Hello World Cookie");
                        HttpCookie cookie = new HttpCookie("MyCookie");
                        cookie.Values.Add("Font", "Times");
                        cookie.Values.Add("User", "Burhan");
                        //suppose if I want cookie to expire in 1 min
                        //DateTime dt = DateTime.Now;
                        //TimeSpan ts = new TimeSpan(0,0,1,0,0);
                        //cookie.Expires = dt.Add(ts);
                        cookie.Expires = DateTime.MaxValue; //For Persistant
                        Response.Cookies.Set(cookie);
                        //AppendCookie function can also be use
                    }
                    else
                    {
                        Response.Write(CookieRef.Values["Font"]);
                        Response.Write("<BR>");
                        Response.Write(CookieRef.Values["User"]);
                    }
                }

            //Cookies for IE
            //C:\Users\username\AppData\Roaming\Microsoft\Windows\Cookies
            //Cookie location for chrome
            //C:\Users\your_username\AppData\Local\Google\Chrome\User Data\Default\
            //For windows 8
            //C:\Users\username\AppData\Local\Microsoft\Windows\INetCookies
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //JUST PLACED THERE TO CAUSE A POSTBACK
        }
    }
}