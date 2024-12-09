using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnStateManagement
{
    public partial class Demo1 : System.Web.UI.Page
    {
          int x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            x = 10;
            //set x value in hiddenfield
            hd1.Value = x.ToString();
            Response.Write(x); //display text(x value) on the page
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Read value from hiddenfield
            x = int.Parse(hd1.Value);
            Response.Write(x);
        }
    }
}