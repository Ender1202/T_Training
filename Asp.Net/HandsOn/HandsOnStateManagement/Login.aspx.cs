using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnStateManagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            string uname=txtUname.Text;
            string pwd=txtPwd.Text;
            if(uname=="Virat" && pwd=="12345")
            {
                //set uname in session
                Session["un"] = uname;
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                //show error msg here!!
            }
        }
    }
}