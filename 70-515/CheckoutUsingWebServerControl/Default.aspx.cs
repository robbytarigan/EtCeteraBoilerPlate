#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
#endregion Usings

public partial class _Default : System.Web.UI.Page {
    public class CartItem {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class BoughtItem {
        public CartItem Item { get; set; }
        public int Quantity { get; set; }
    }

    public class CheckoutDetail {
        private List<BoughtItem> items = new List<BoughtItem>();

        public List<BoughtItem> Items { get { return items; } }
        public string DespatchAddress { get; set; }
    }

    private List<CartItem> AvailableItems = new List<CartItem>() { 
        new CartItem { Id=1, Name="Nice Jacket", Price= 5.00},
        new CartItem { Id=2, Name="Sony Alpha Camera", Price= 400.00},
        new CartItem { Id=3, Name=".NET Training Kit Book", Price=35.99 },
        new CartItem { Id=4, Name="Blue Jumper", Price= 20.23},
        new CartItem { Id=5, Name="Modern Jeans", Price= 19.79}
    };

    private CartItem FindItem(int itemId) {
        return AvailableItems.Single(a => a.Id == itemId);
    }

    private CheckoutDetail Detail {
        get {
            return Session["Detail"] != null ? (CheckoutDetail)Session["Detail"] : new CheckoutDetail();
        }
        set {            
            Session["Detail"] = value;
        }
    }

    private void RenderSpecifyQuantityStep() {
        foreach (BoughtItem item in Detail.Items) {
            QuantityItemControl itemControl = (QuantityItemControl)Page.LoadControl("~/QuantityItemControl.ascx");
            itemControl.ID = String.Format("item{0}", item.Item.Id);
            itemControl.Name = item.Item.Name;
            itemControl.Quantity = item.Quantity;

            
            quantityItemPlaceHolder.Controls.Add(itemControl);
        }
    }

    private void RenderFillDespatchAddress() {
        despatchAddressTextBox.Text = Detail.DespatchAddress;
    }

    private void RenderConfirmation() {
        CheckoutDetail currentDetail = Detail;

        double totalPrice = 0D;

        foreach (BoughtItem item in currentDetail.Items) {
            TableRow itemRow = new TableRow();
            itemRow.Cells.Add(new TableCell { Text = item.Item.Name });
            itemRow.Cells.Add(new TableCell { Text = item.Quantity.ToString() });
            itemRow.Cells.Add(new TableCell { Text = item.Item.Price.ToString("N2") });

            confirmationItemTable.Rows.Add(itemRow);

            totalPrice += item.Quantity * item.Item.Price;            
        }

        TableRow footerRow = new TableRow();
        footerRow.Cells.Add(new TableCell { Text = "Total Price" });
        footerRow.Cells.Add(new TableCell { Text = totalPrice.ToString("N2"), ColumnSpan = 2 });

        confirmationItemTable.Rows.Add(footerRow);

        confirmationDespatchAddressLabel.Text = currentDetail.DespatchAddress;
    }

    private void SetItemList() {
        CheckoutDetail currentDetail = Detail;
        currentDetail.Items.Clear();

        foreach (ListItem checkItem in itemCheckBoxList.Items) {
            if (checkItem.Selected)
                currentDetail.Items.Add(new BoughtItem { Item = FindItem(Int32.Parse(checkItem.Value)), Quantity = 1 });
        }

        Detail = currentDetail;
    }

    private void SetQuantity() {
        CheckoutDetail currentDetail = Detail;

        foreach (BoughtItem item in currentDetail.Items) {
            QuantityItemControl itemControl = (QuantityItemControl)Page.LoadControl("~/QuantityItemControl.ascx");
            itemControl.ID = String.Format("item{0}", item.Item.Id);
            quantityItemPlaceHolder.Controls.Add(itemControl);
            item.Quantity = itemControl.Quantity;
        }

        Detail = currentDetail;
    }

    private void SetDespatchAddress() {
        CheckoutDetail currentDetail = Detail;
        currentDetail.DespatchAddress = despatchAddressTextBox.Text;

        Detail = currentDetail;
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
            case 2:
                RenderFillDespatchAddress();
                break;
            case 3:
                RenderConfirmation();
                break;
        }
    }

    protected void checkoutWizard_NextButtonClick(object sender, WizardNavigationEventArgs e) {
        switch (e.NextStepIndex) {
            case 1:
                SetItemList();
                break;
            case 2:
                SetQuantity();
                break;
            case 3:
                SetDespatchAddress();
                break;
        }
    }
}
