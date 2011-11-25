using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class GetName : System.Web.UI.UserControl
{
    private string _name = String.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void SubmitButton_Click(object sender, EventArgs e) {
        _name = NameTextBox.Text;
    }
    
    [ConnectionProvider("User name provider", "GetUserName")]
    public string GetUserName() { return _name;  }

    [Personalizable]
    public string UserName {
        get { return _name; }
        set { _name = value; }
    }
}