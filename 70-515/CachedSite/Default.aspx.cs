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
        OtherMessageLiteral.Text = String.Format("Load time : {0}", DateTime.Now.TimeOfDay);
    }
    protected void SubmitButton_Click(object sender, EventArgs e) {
        ChosenLabel.Text = String.Format("{0} at {1}", ChoiceDropDownList.
            SelectedValue,
            DateTime.Now.TimeOfDay.ToString());
    }
}
