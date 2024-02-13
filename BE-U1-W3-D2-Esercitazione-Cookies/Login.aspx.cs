using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE_U1_W3_D2_Esercitazione_Cookies
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Login_cookie");
            cookie.Values["username"] = Username.Text;
            cookie.Values["password"] = Password.Text;
            cookie.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(cookie);
           

            if (Request.Cookies["cookie"] != null)
            {
                Response.Write(Request.Cookies["Login_cookie"]["username"] + "<br/>" +
                    Request.Cookies["Login_cookie"]["password"]);
            } 
            Response.Redirect("Logout.aspx");
        }
    }
}