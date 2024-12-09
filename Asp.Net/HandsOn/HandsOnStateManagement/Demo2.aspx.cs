using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnStateManagement
{
    public partial class Demo2 : System.Web.UI.Page
    {
        int x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            x = 10;
            //set x value in viewstate object
            ViewState["key"] = x;
            Label1.Text = "Hello "+TextBox1.Text;
            Response.Write(x);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            x=(int)ViewState["key"];
            Response.Write(x);
        }
    }
}