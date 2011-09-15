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
        if (UserTypeDropDownList.SelectedValue == "G") {
            PasswordLabel.Visible = false;
            PasswordTextBox.Visible = false;
            UserNameLabel.Text = "E-mail address: ";
            LogonButton.Text = "Visit";
        } else {
            PasswordLabel.Visible = true;
            PasswordTextBox.Visible = true;
            UserNameLabel.Text = "Username: ";
            LogonButton.Text = "Logon";
        }
    }

    protected void LogonButton_Click(object sender, EventArgs e) {
        Response.Redirect("Home.aspx");
    }
}