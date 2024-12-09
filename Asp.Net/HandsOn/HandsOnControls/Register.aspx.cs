using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnControls
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveUser(object sender, EventArgs e)
        {
            //Save details to backend tabel
            //navigate to login page
            Response.Redirect("Login.aspx");
            //navigate other server
            Response.Redirect("http://www.google.co.in");
        }
    }
}