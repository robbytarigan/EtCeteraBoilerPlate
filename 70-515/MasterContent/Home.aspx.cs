using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void OKButton_Click(object sender, EventArgs e) {
        if (UserNameTextBox.Text != String.Empty) {
            Session["UserName"] = UserNameTextBox.Text;
            Label welcome = (Label)Master.FindControl("GreetingLabel");
            welcome.Text = String.Format("Welcome, {0}!", Session["UserName"]);
        }
    }
}