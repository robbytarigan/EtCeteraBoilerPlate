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

}