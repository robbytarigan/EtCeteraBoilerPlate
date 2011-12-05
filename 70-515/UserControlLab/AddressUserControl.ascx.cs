using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddressUserControl : System.Web.UI.UserControl {
    public event EventHandler SaveButtonClick;

    public string Address {
        get { return TextBoxAddress.Text; }
        set { TextBoxAddress.Text = value; }
    }
    public string City {
        get { return TextBoxCity.Text; }
        set { TextBoxCity.Text = value; }
    }
    public string StateProvince {
        get { return TextBoxStateProv.Text; }
        set { TextBoxStateProv.Text = value; }
    }
    public string PostalCode {
        get { return TextBoxPostalCode.Text; }
        set { TextBoxPostalCode.Text = value; }
    }

    protected void ButtonSave_Click(object sender, EventArgs e) {
        if (SaveButtonClick != null) {
            SaveButtonClick(this, new EventArgs());
        }
    }
}