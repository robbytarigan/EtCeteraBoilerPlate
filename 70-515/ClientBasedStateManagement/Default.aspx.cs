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

    }


    protected void LookButton_Click(object sender, EventArgs e) {
        resultLabel.Text = String.Format("Index = {0}, IndexViewState = {1}, Session = {2}", test1.Index, test1.IndexInViewState, Session["Test"]??0);

        test1.Index = test1.Index + 1;
        test1.IndexInViewState = test1.IndexInViewState + 1;

        if (Session["Test"] == null) {
            Session["Test"] = 1;
        } else {
            Session["Test"] = (int)Session["Test"] + 1;
        }
    }
}