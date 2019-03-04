using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_27_hello_world
{
    public partial class MagePage : System.Web.UI.Page
    {
        int counter = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Text = "0";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = $"You have click {counter.ToString()} times";
            counter++;
        }
    }
}