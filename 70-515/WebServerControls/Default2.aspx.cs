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

    }

    protected void AddButton_Click(object sender, EventArgs e) {
        if (!(NameTextBox.Text == String.Empty)) {
            DestinationsCheckBoxList.Items.Add(Server.HtmlEncode(NameTextBox.Text));
            NameTextBox.Text = null;
        }
    }

    protected void ShipButton_Click(object sender, EventArgs e) {
        if ((ShippingTypeRadioButtonList.SelectedValue == String.Empty) || (DestinationsCheckBoxList.SelectedValue == String.Empty)) {
            ShippingConfirmationLabel.Text = "You must select a shipping type and at least one destination.";
        } else {
            ShippingConfirmationLabel.Text =
            string.Format("Using {0} shipping to:<br>", ShippingTypeRadioButtonList.SelectedValue);
            foreach (ListItem li in DestinationsCheckBoxList.Items) {
                if (li.Selected) {
                    ShippingConfirmationLabel.Text += li.Value + "<br>";
                }
            }
        }
    }

}