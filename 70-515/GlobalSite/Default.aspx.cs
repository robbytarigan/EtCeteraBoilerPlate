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
        foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.SpecificCultures)) {
            DropDownListLang.Items.Add(new ListItem(ci.NativeName, ci.Name));
        }

        if (!IsPostBack) {            
            DropDownListLang.SelectedIndex = DropDownListLang.Items.IndexOf(DropDownListLang.Items.FindByValue(Request.UserLanguages[0]));
        }
    }

    protected override void InitializeCulture() {
        
        if (Request.Form["DropDownListLang"] != null) {
            UICulture = Request.Form["DropDownListLang"];
        }

        base.InitializeCulture();
    }
}