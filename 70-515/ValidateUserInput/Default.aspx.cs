﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void submitButton_Click(object sender, EventArgs e) {
        if (!IsValid)
            return;

        entryLiteral.Text = String.Format(@"<div>
<p>Account Number: {0}</p>
<p>Date of Birth: {1} </p>
</div>", accountNumberTextBox.Text, birthDateTextBox.Text);
    }

    protected void birthDatePastCustomeValidator_ServerValidate(object source, ServerValidateEventArgs args) {
        DateTime birthDate;
        DateTime.TryParseExact(args.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture , DateTimeStyles.None, out birthDate);

        args.IsValid = birthDate < DateTime.Today;
    }
}