using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NorthwindClient.NwServices;

namespace NorthwindClient {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void ButtonGet_Click(object sender, EventArgs e) {
            //todo: add validation & error handling
            int shipperId = int.Parse(TextBoxShipperCode.Text);

            ShipperServiceClient nwShipper = new ShipperServiceClient();

            Shipper shipper = new Shipper();

            shipper = nwShipper.GetShipper(shipperId);
            TextBoxShipperId.Text = shipper.ShipperId.ToString();
            TextBoxCompany.Text = shipper.CompanyName;
            TextBoxPhone.Text = shipper.Phone;
        }

        protected void ButtonSave_Click(object sender, EventArgs e) {
            //todo: add validation & error handling
            Shipper shipper = new Shipper();

            shipper.ShipperId = int.Parse(TextBoxShipperId.Text);
            shipper.CompanyName = TextBoxCompany.Text;
            shipper.Phone = TextBoxPhone.Text;

            ShipperServiceClient nwShipper = new ShipperServiceClient();

            nwShipper.SaveShipper(shipper);
        }
    }
}