using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResourceNotFound : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        messageLiteral.Text = String.Format("<h1>Resource {0} which you tried to access is not found on the web server.</h1>", Request.QueryString["aspxerrorpath"]);
    }
}