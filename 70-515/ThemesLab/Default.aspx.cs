using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    protected void Page_PreInit(object sender, EventArgs e) {
        if (Session["theme"] != null) {
            Page.Theme = (string)Session["theme"];
        }
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e) {
        string theme = Page.Theme;
        //switch themes
        if (theme == "Contoso") {
            Session["theme"] = "Fabrikam";
        } else {
            Session["theme"] = "Contoso";
        }
        //Page.Theme = (string)Session["theme"]; // Exception here
        Server.Transfer(Request.Path);
    }
}