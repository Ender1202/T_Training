using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnStateManagement
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["un"] != null)
                Label1.Text = Session["un"].ToString(); //Read Session data
            else
                Response.Redirect("Login.aspx");
        }
    }
}