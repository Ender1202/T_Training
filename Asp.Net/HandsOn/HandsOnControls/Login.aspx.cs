using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnControls
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ValidateUser(object sender, EventArgs e)
        {
            string uname=txtUname.Text;
            string pwd=txtPwd.Text;
            if (uname == "Virat" && pwd == "12345")
            {
                //lblMsg.Text = "Valid User";
                Response.Redirect("Dashboard.aspx");
            }
            else
                lblMsg.Text = "Invalid User";

        }
    }
}