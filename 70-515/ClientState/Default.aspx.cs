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
        int clicks = 0;
        int.TryParse(HiddenField1.Value, out clicks);
        clicks++;
        HiddenField1.Value = clicks.ToString();
        Label1.Text = "HiddenField clicks: " + HiddenField1.Value;
    }
}
