using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCustomControls {
    [ToolboxData("<{0}:StateListControl runat=\"server\" ID=\"stateListControl1\"></{0}:StateListControl>")]
    public class StateListControl : DropDownList {
        public StateListControl() {
            this.Items.Add(new ListItem("Alabama", "AL"));
            this.Items.Add(new ListItem("Alaska", "AK"));
            this.Items.Add(new ListItem("Arizona", "AZ"));
            this.Items.Add(new ListItem("Arkansas", "AR"));
            this.Items.Add(new ListItem("California", "CA"));
            //and more ...
        }
    }
}
