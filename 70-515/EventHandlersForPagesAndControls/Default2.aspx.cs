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
        TextBox colorTextBox = new TextBox() { ID = "colorTextBox" };
        Button submitButton = new Button() { ID="submitButton", Text = "Submit" };

        submitButton.Click += new EventHandler(submitButton_Click);
        containerPlaceHolder.Controls.Add(colorTextBox);
        containerPlaceHolder.Controls.Add(submitButton);

    }

    void submitButton_Click(object sender, EventArgs e) {
        TextBox colorTextBox = containerPlaceHolder.FindControl("colorTextBox") as TextBox;

        if (colorTextBox != null) {
            resultLabel.Text = String.Format("Posted {0} <br />", colorTextBox.Text);
        }
    }
}