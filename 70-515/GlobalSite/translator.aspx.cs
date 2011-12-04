using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Xml.Linq;
using System.IO;

public partial class TranslatorPage : System.Web.UI.Page
{

    private string selectedLanguage;

    protected override void OnPreInit(EventArgs e) {
        base.OnPreInit(e);

        foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.SpecificCultures)) {
            DropDownListLang.Items.Add(new ListItem(ci.NativeName, ci.Name));
        }
    }

    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);
        selectedLanguage = DropDownListLang.SelectedValue;
    }

    protected override void OnLoadComplete(EventArgs e) {
        base.OnLoadComplete(e);

        string localResourceFolder = Server.MapPath("App_LocalResources");
        string resourceFile = String.Format("{0}/Default.aspx{1}.resx", localResourceFolder, String.IsNullOrWhiteSpace(selectedLanguage)?String.Empty:"." + selectedLanguage);

        if (!File.Exists(resourceFile)) {
            string defaultResourceFile = String.Format("{0}/Default.aspx.resx", localResourceFolder);
            File.Copy(defaultResourceFile, resourceFile);
        }

        XDocument doc = XDocument.Load(resourceFile);

        bool anyChanged = false;

        foreach (XElement el in doc.Descendants("data")) {
            string name = el.Attribute(XName.Get("name")).Value;

            string inputName = String.Format("{0}TextBox", name);

            string value = Request.Form[inputName];

            if (value != null) {
                anyChanged = true;
                el.Descendants("value").Single().Value = value;
            } else {
                value = el.Descendants("value").Single().Value;
            }

            controlHolder.Controls.Add(new Label { ID = String.Format("{0}Label", name), Text = name, AssociatedControlID = inputName });
            controlHolder.Controls.Add(new TextBox { ID = inputName, Text = value });
            controlHolder.Controls.Add(new Literal { Text = "<br />" });            
        }

        if (anyChanged) {
            doc.Save(resourceFile);
        }
        
    }

    
}