using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddressUcTemplated : System.Web.UI.UserControl {
    protected void Page_Init(object sender, EventArgs e) {
        //clear the controls from the placeholder
        PlaceHolderAddressTemplate.Controls.Clear();
        if (LayoutTemplate == null) {
            PlaceHolderAddressTemplate.Controls.Add(
            new LiteralControl("No template defined."));
        } else {
            this.Address = new global::Address();

            AddressUcContainer container = new AddressUcContainer(this.Address);

            this.LayoutTemplate.InstantiateIn(container);
            //add the controls to the placeholder
            PlaceHolderAddressTemplate.Controls.Add(container);
        }
    }

    [PersistenceMode(PersistenceMode.InnerProperty)]
    [TemplateContainer(typeof(AddressUcContainer))]
    public ITemplate LayoutTemplate { get; set; }
    
    public Address Address { get; set; }
    public string AddressType { get; set; }
}