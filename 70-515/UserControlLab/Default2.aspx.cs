using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            //simulate getting a user and loading his or her profile        
            AddressUcTemplated1.Address.AddressLine1 = "1234 Some St.";
            AddressUcTemplated1.Address.City = "Ann Arbor";
            AddressUcTemplated1.Address.State = "MI";
            AddressUcTemplated1.Address.PostalCode = "48888";

            //bind data to controls
            Page.DataBind();
        }
    }

    protected void ButtonSave_Click(object sender, EventArgs e) {
        //Debug.WriteLine(AddressUcTemplated1.Address.AddressLine1);
    }
}