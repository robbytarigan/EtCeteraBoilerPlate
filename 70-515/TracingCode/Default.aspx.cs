using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{    

    protected void Page_PreInit(object sender, EventArgs e) {
        timeLabel.Text = String.Format("Current server time is {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Trace.Write("Custom Category", "Page.Load called");
    }
}