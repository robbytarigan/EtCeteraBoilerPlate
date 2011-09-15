using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

[Themeable(true)]
public partial class Setting : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private string color;

    public string Color {
        get { return color; }
        set { color = value; }
    }
}