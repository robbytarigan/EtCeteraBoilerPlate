#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
#endregion Usings

public partial class _Default : System.Web.UI.Page {
    public class CartItem {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    private List<CartItem> AvailableItems = new List<CartItem>() { 
        new CartItem { Id=1, Name="Nice Jacket", Price= 5.00},
        new CartItem { Id=2, Name="Sony Alpha Camera", Price= 400.00},
        new CartItem { Id=3, Name=".NET Training Kit Book", Price=35.99 },
        new CartItem { Id=4, Name="Blue Jumper", Price= 20.23},
        new CartItem { Id=5, Name="Modern Jeans", Price= 19.79}
    };

    private void RenderSpecifyQuantityStep() {

    }

    protected override void OnInit(EventArgs e) {
        base.OnInit(e);

        itemCheckBoxList.DataSource = AvailableItems;
        itemCheckBoxList.DataBind();
    }

    protected override void OnLoadComplete(EventArgs e) {
        base.OnLoadComplete(e);

        switch (checkoutWizard.ActiveStepIndex) {
            case 1:
                RenderSpecifyQuantityStep();
                break;
        }
    }
}
