using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE_U1_W3_D2_Esercitazione_Cookies
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Login_cookie"];
            if (cookie != null)
            {
               UsernameLabel.Text = "Login di " + Request.Cookies["Login_cookie"]["username"] + " avvenuto con successo!";
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
        if(Request.Cookies["Login_cookie"] != null)
            {
                HttpCookie cookie = new HttpCookie("Logout_cookie");
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
                Response.Redirect("Login.aspx");
            }
        }
    }
}