using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnStateManagement
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string n = TextBox1.Text;
            // Response.Redirect("Page2.aspx?un="+n); //Querystring
            //set n value in cookie
            Response.Cookies["n"].Value = n;
            Response.Cookies["n"].Expires = DateTime.Now.AddDays(5); //Cookie will save 5 days in local machine
            Response.Redirect("Page2.aspx");
        }
    }
}