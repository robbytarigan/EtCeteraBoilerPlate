using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Read the cookie clicks and increment
        int cookieClicks;
        if (Request.Cookies["clicks"] != null) {
            cookieClicks = int.Parse(Request.Cookies["clicks"].Value) + 1;
        } else {
            cookieClicks = 1;
        }
        // Save the cookie to be returned on the next visit
        Response.Cookies["clicks"].Value = cookieClicks.ToString();
        Label1.Text = "Cookie clicks: " + cookieClicks.ToString();
    }
}
