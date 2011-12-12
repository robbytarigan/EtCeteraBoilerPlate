using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ScriptDebug : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        int a = 10;
        int b = 20;

        Response.Write(String.Format("{0} + {1} = {2}", a, b, a + b));
    }
}