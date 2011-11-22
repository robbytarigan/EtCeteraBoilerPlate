#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
#endregion Usings
public partial class Default2 : System.Web.UI.Page
{
    void GenerateModeList(object sender, EventArgs e) {
        WebPartManager _manager = WebPartManager.GetCurrentWebPartManager(Page);        
        String browseModeName = WebPartManager.BrowseDisplayMode.Name;
        DropDownListModes.Items.Clear();
        // Fill the drop-down list with the names of supported display modes.
        foreach (WebPartDisplayMode mode in _manager.SupportedDisplayModes) {
            String modeName = mode.Name;
            // Make sure a mode is enabled before adding it.
            if (mode.IsEnabled(_manager)) {
                ListItem item = new ListItem(modeName, modeName);
                DropDownListModes.Items.Add(item);
            }
        }
        // Select the current mode
        ListItemCollection items = DropDownListModes.Items;
        int selectedIndex = items.IndexOf(items.FindByText(_manager.DisplayMode.Name));
        DropDownListModes.SelectedIndex = selectedIndex;
    }

    void DropDownListModes_SelectedIndexChanged(object sender, EventArgs e) {
        WebPartManager manager =WebPartManager.GetCurrentWebPartManager(Page);
        WebPartDisplayMode mode = manager.SupportedDisplayModes[DropDownListModes.SelectedValue];
        if (mode != null)
            manager.DisplayMode = mode;
    }    
    
    void Page_Init(object sender, EventArgs e)
    {
        Page.InitComplete += new EventHandler(GenerateModeList);
        DropDownListModes.SelectedIndexChanged += new EventHandler(DropDownListModes_SelectedIndexChanged);
    }

    protected void Page_Load(object sender, EventArgs e) {

    }
}