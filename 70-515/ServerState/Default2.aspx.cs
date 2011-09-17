using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Application.Lock();
        Application["clicks"] = ((int)Application["clicks"]) + 1;
        Application.UnLock();
        Label1.Text = string.Format("Application clicks: {0}",
        Application["clicks"].ToString());

        Session["session_clicks"] = (int)Session["session_clicks"] + 1;
        Label2.Text = string.Format("Session clicks: {0}", Session["session_clicks"].ToString());
    }
}