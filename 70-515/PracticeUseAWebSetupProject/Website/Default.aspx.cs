using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the web.config of current application

        Configuration config = WebConfigurationManager.OpenWebConfiguration("~/");

        ConnectionStringsSection connectionStrings = config.ConnectionStrings;

        string applicationServicesConnectionString = connectionStrings.ConnectionStrings["ApplicationServices"].ConnectionString;


        Response.Write("ApplicationServices connection string is " + applicationServicesConnectionString);

    }
}
