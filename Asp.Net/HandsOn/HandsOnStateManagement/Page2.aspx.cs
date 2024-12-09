using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnStateManagement
{
    public partial class Page2 : System.Web.UI.Page
    {
        //This  Page_Load() method invokes when page is loaded in the browser
        protected void Page_Load(object sender, EventArgs e)
        {
            //Read querystring value
            //string s = Request.QueryString["un"];
            string s = "Guest";
            if (Request.Cookies["n"] != null)
            {
                 s = Request.Cookies["n"].Value;
            }
            Label1.Text = s;
        }
    }
}