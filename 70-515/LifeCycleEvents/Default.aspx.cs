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
        System.Diagnostics.Debug.WriteLine("Page_Load");
    }

    protected void Page_PreInit(object sender, EventArgs e) {
        System.Diagnostics.Debug.WriteLine("Page_PreInit");
    }
    protected void Page_Init(object sender, EventArgs e) {
        System.Diagnostics.Debug.WriteLine("Page_Init");
    }
    protected void Page_PreRender(object sender, EventArgs e) {
        System.Diagnostics.Debug.WriteLine("Page_PreRender");
    }
    protected void Page_Unload(object sender, EventArgs e) {
        System.Diagnostics.Debug.WriteLine("Page_Unload");
    }
}
