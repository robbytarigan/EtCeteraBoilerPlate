using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected override void OnPreInit(EventArgs e) {
        base.OnPreInit(e);

        accountUC.AccountLetterItems.Add("N");
        accountUC.AccountLetterItems.Add("Q");
    }

    protected override void OnInit(EventArgs e) {
        base.OnInit(e);

        accountUC.ContinueClick += new EventHandler<ContinueEventArgs>(accountUC_ContinueClick);
    }

    void accountUC_ContinueClick(object sender, ContinueEventArgs e) {
        accountFact.Text = String.Format(@"Account number = {0} 
<br />
Account Letter = {1}", e.AccountNumber, e.AccountLetter);
    }
}