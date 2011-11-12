using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class QuantityItemControl : System.Web.UI.UserControl {
    private int quantity;

    public string Name {
        get { return quantityLabel.Text; }
        set { quantityLabel.Text = value; }
    }

    public int Quantity {
        get {
            if (quantity < 1) {
                Int32.TryParse(Request.Form[quantityTextBox.UniqueID], out quantity);
            }

            return quantity;
        }

        set {
            quantity = value;
            quantityTextBox.Text = quantity.ToString();            
        }
    }
    
    

}