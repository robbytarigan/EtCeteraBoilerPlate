using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.NeutralCultures)) {
            DropDownListLang.Items.Add(new ListItem(ci.NativeName, ci.Name));
        }        
    }

    protected override void InitializeCulture() {
        
        if (Request.Form["DropDownListLang"] != null) {
            UICulture = Request.Form["DropDownListLang"];
        }

        base.InitializeCulture();
    }
}