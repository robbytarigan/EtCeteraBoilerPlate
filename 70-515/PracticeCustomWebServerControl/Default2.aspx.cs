﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);
        LabeledTextBox1.DataBind();        
    }
}