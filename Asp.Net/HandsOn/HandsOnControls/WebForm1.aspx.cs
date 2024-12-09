using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnControls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Event Handler
        protected void GreetUser(object sender, EventArgs e)
        {
            string name=txtName.Text; //retun textbox value entered by user
            lblMsg.Text = "Good Morning " + name;

        }
    }
}