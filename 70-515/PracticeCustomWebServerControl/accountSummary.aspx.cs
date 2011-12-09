using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class accountSummary : System.Web.UI.Page
{
    protected override void OnInit(EventArgs e) {
        base.OnInit(e);

        messageLabel.Text = String.Format("You choose {0}", AccountNumberQuester1.AccountNumber);

        AccountNumberQuester1.AccountNumber = "Please enter again account number";
    }
}