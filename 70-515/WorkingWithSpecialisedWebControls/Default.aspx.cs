using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            Wizard1.ActiveStepIndex = 0;
            OfficeImageMap.HotSpotMode = HotSpotMode.PostBack;

            OfficeImageMap.HotSpots.Add(GetHotSpot("Cubicle A", 0, 0, 123, 105));
            OfficeImageMap.HotSpots.Add(GetHotSpot("Cubicle B", 124, 0, 262, 105));
            OfficeImageMap.HotSpots.Add(GetHotSpot("Cubicle C", 263, 0, 382, 105));
            OfficeImageMap.HotSpots.Add(GetHotSpot("Cubicle D", 258, 164, 382,
            286));
            OfficeImageMap.HotSpots.Add(GetHotSpot("Cubicle E", 135, 164, 257,
            286));
            OfficeImageMap.HotSpots.Add(GetHotSpot("Cubicle F", 0, 164, 134, 286));
        }
    }

    private RectangleHotSpot GetHotSpot(string name, int left, int top, int right, int bottom) {
        RectangleHotSpot rhs = new RectangleHotSpot();
        rhs.PostBackValue = name;
        rhs.Left = left;
        rhs.Top = top;
        rhs.Right = right;
        rhs.Bottom = bottom;
        return rhs;
    }

    protected void OfficeImageMap_Click(object sender, ImageMapEventArgs e) {
        OfficeSelectedLabel.Text = e.PostBackValue;
    }

    protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e) {
        Wizard1.Visible = false;
        Response.Write("Thank you! Your request is being processed.");
    }

    protected void Wizard1_ActiveStepChanged(object sender, EventArgs e) {
        if (Wizard1.ActiveStep.Title == "Summary") {
            SummaryLabel.Text = string.Format("Summary Info:<br />Room: {0}<br />Delivery Date: {1}",
                OfficeSelectedLabel.Text,
                ServiceDateCalendar.SelectedDate.ToShortDateString());
        }
    }
}