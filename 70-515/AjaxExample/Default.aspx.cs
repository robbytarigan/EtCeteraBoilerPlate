﻿using System;
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
    protected void ButtonSave_Click(object sender, EventArgs e) {
        SqlDataSourceNwd.Insert();
        GridView1.DataBind();

        TextBoxCompany.Text = "";
        TextBoxContact.Text = "";
        TextBoxCity.Text = "";
        TextBoxPhone.Text = "";
        System.Threading.Thread.Sleep(2000);
    }
}
