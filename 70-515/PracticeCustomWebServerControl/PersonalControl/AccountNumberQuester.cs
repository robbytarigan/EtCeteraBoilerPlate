using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Web;
using System.IO;

namespace PersonalControl {
    public class AccountNumberSearchEventArgs: EventArgs    {
        private readonly string accountNumber;

        public AccountNumberSearchEventArgs(string accountNumber) {
            this.accountNumber = accountNumber.PadLeft(7, '0');
        }

        public string AccountNumber {
            get { return accountNumber; }
        }
    }

    public class AccountNumberQuester : CompositeControl {
        private const string MenuID = "Menu";
        private const string AccountNumberID = "AccountNumber";
        private const string AccountQueryString = "ac";
        private const string SearchID = "Search";        

        public event EventHandler<AccountNumberSearchEventArgs> Search;

        private HttpContext currentContext = HttpContext.Current;

        public string SelectedMenu {
            get { 
                DropDownList ddl = (DropDownList)FindControl(MenuID);
                return ddl.SelectedValue;
            }

            set {
                DropDownList ddl = (DropDownList)FindControl(MenuID);
                ddl.SelectedIndex = ddl.Items.IndexOf(ddl.Items.FindByValue(value));
            }
        }


        public string AccountNumber {
            get {
                TextBox txt = (TextBox)FindControl(AccountNumberID);
                return txt.Text;
            }

            set {
                TextBox txt = (TextBox)FindControl(AccountNumberID);
                txt.Text = value;
            }
        }

        private void RedirectPage() {
            currentContext.Response.Redirect(String.Format("{0}?{2}={1}", SelectedMenu, AccountNumber, AccountQueryString));
        }

        protected override void CreateChildControls() {
            base.CreateChildControls();

            Panel pnl = new Panel();
            DropDownList ddl = new DropDownList() { ID = MenuID, AutoPostBack = true };

            ddl.Items.AddRange(new ListItem[] { 
                new ListItem("Account Summary", "accountSummary.aspx"),
                new ListItem("Holdings", "allHoldings.aspx"),
                new ListItem("Credit Limit", "creditLimit.aspx"),
                new ListItem("Ledgers", "ledgers.aspx")
            });

            ddl.SelectedIndex = ddl.Items.IndexOf(ddl.Items.FindByValue(Path.GetFileName(currentContext.Request.Path)));

            TextBox txt = new TextBox() { ID = AccountNumberID, Text = currentContext.Request.QueryString[AccountQueryString] };
            Button btn = new Button() { ID = SearchID, Text = "Go" };
            btn.Click += new EventHandler(btn_Click);
            ddl.SelectedIndexChanged += new EventHandler(ddl_SelectedIndexChanged);

            Controls.Add(pnl);
            pnl.Controls.Add(ddl);
            pnl.Controls.Add(txt);            
            pnl.Controls.Add(btn);
        }

        void ddl_SelectedIndexChanged(object sender, EventArgs e) {
            RedirectPage();
        }

        void btn_Click(object sender, EventArgs e) {
            RedirectPage();
        }
    }
}
