using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class ShowNameBackwards : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [ConnectionConsumer("User name consumer", "GetName")]
    public void GetName(string Name) {
        char[] NameCharArray = Name.ToCharArray();
        Array.Reverse(NameCharArray);
        BackwardsLabel.Text = "Your name backward is: " + new string(NameCharArray);
    }
}