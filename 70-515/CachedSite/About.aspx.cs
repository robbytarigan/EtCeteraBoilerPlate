using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        ParagraphLiteral.Text = String.Format(@"Load time is {0} <br />
Every time a website requests your location data, Opera tells you, and asks your permission to send it. 
<br >
 With your permission, Opera passes the location data to Google Location Services, and sends an estimated latitude and longitude to the website. Opera does not save location data, nor are any cookies generated. Every time your location is requested, Opera redetermines the location data. 
<br >
 The data passed to Google includes location data, plus a random client identifier (opera:config#Geolocation|AccessToken) assigned by Google, that expires after 2 weeks. The client identifier is used to distinguish requests, not to identify you. The data passed to Google is governed by Google's own Privacy Policy. 
<br >
 The location information sent to the website is governed by the website's privacy policy. It is the responsibility of the website to dispose of this information in a way that is consistent with the W3C's Geolocation API Specification.",
        DateTime.Now.TimeOfDay);
    }

    protected void SubmitButton_Click(object sender, EventArgs e) {
        ParagraphLiteral.Text += String.Format("<br /> The paragraph generated last time on {0}", DateTime.Now.TimeOfDay);
    }
}
