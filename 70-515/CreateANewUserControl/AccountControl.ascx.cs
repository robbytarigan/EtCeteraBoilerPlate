using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AccountControl : System.Web.UI.UserControl
{
    public event EventHandler<ContinueEventArgs> ContinueClick;

    public string AccountNumberLabel {
        get { return accountNumberLabel.Text; }
        set { accountNumberLabel.Text = value; }
    }

    public string AccountLetterLabel {
        get { return accountLetterLabel.Text; }
        set { accountLetterLabel.Text = value; }
    }

    public ListItemCollection AccountLetterItems {
        get { return accountLetterDropDownList.Items; }        
    }

    protected void continueButton_Click(object sender, EventArgs e) {
        if (ContinueClick != null) {
            ContinueClick(this, new ContinueEventArgs { AccountNumber = accountNumberTextBox.Text, AccountLetter = Char.Parse(accountLetterDropDownList.SelectedValue) });
        }
    }
}