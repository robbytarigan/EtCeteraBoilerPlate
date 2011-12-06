using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            StateListControl1.Items.Add(new ListItem("Michigan", "MI"));
        }
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e) {
        LabelSelected.Text = StateListControl1.SelectedItem.Text + ", "
        + StateListControl1.SelectedItem.Value;
    }
}