using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Content1 : System.Web.UI.Page
{
    
    protected void Page_PreInit(object sender, EventArgs e) {
        if (Session["Master"] != null) {
            MasterPageFile = String.Format("{0}.master", (string)Session["Master"]);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Page_LoadComplete(object sender, EventArgs e) {
        if (Session["Master"] != null) {
            MasterDropDownList.SelectedValue = (string)Session["Master"];
        }
    }

    protected void SelectButton_Click(object sender, EventArgs e) {
        Session["Master"] = MasterDropDownList.SelectedValue;
        Server.Transfer("Content1.aspx");
    }
}