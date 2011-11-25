using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class Default3 : System.Web.UI.Page
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
        WebPartManager manager = WebPartManager.GetCurrentWebPartManager(Page);
        WebPartDisplayMode mode = manager.SupportedDisplayModes[DropDownListModes.SelectedValue];
        if (mode != null)
            manager.DisplayMode = mode;
    }

    void Page_Init(object sender, EventArgs e) {
        Page.InitComplete += new EventHandler(GenerateModeList);
        DropDownListModes.SelectedIndexChanged += new EventHandler(DropDownListModes_SelectedIndexChanged);
    }

    protected void Page_PreRender(object sender, EventArgs e) {
        // Set properties on verbs.
        connectionsZone1.CancelVerb.Description =
          "Terminates the connection process";
        connectionsZone1.CloseVerb.Description =
          "Closes the connections UI";
        connectionsZone1.ConfigureVerb.Description =
          "Configure the transformer for the connection";
        connectionsZone1.ConnectVerb.Description =
          "Connect two WebPart controls";
        connectionsZone1.DisconnectVerb.Description =
          "End the connection between two controls";

        // Set properties for UI text strings.
        connectionsZone1.ConfigureConnectionTitle =
          "Configure";
        connectionsZone1.ConnectToConsumerInstructionText =
          "Choose a consumer connection point";
        connectionsZone1.ConnectToConsumerText =
          "Select a consumer for the provider to connect with";
        connectionsZone1.ConnectToConsumerTitle =
          "Send data to this consumer";
        connectionsZone1.ConnectToProviderInstructionText =
          "Choose a provider connection point";
        connectionsZone1.ConnectToProviderText =
          "Select a provider for the consumer to connect with";
        connectionsZone1.ConnectToProviderTitle =
          "Get data from this provider";
        connectionsZone1.ConsumersInstructionText =
          "WebPart controls that receive data from providers";
        connectionsZone1.ConsumersTitle = "Consumer Controls";
        connectionsZone1.GetFromText = "Receive from";
        connectionsZone1.GetText = "Retrieve";
        connectionsZone1.HeaderText =
         "Create and Manage Connections";
        connectionsZone1.InstructionText =
         "Manage connections for the selected WebPart control";
        connectionsZone1.InstructionTitle =
          "Manage connections for consumers or providers";
        connectionsZone1.NoExistingConnectionInstructionText =
          "No connections exist. Click the above link to create "
          + "a connection.";
        connectionsZone1.NoExistingConnectionTitle =
          "No current connections";
        connectionsZone1.ProvidersInstructionText =
          "WebPart controls that send data to consumers";
        connectionsZone1.ProvidersTitle = "Provider controls";

    }
}