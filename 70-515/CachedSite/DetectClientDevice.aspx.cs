using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DetectClientDevice : System.Web.UI.Page
{
    public static bool IsMobileBrowser() {
        //GETS THE CURRENT USER CONTEXT
        HttpContext context = HttpContext.Current;

        //FIRST TRY BUILT IN ASP.NT CHECK
        if (context.Request.Browser.IsMobileDevice) {
            return true;
        }
        //THEN TRY CHECKING FOR THE HTTP_X_WAP_PROFILE HEADER
        if (context.Request.ServerVariables["HTTP_X_WAP_PROFILE"] != null) {
            return true;
        }
        //THEN TRY CHECKING THAT HTTP_ACCEPT EXISTS AND CONTAINS WAP
        if (context.Request.ServerVariables["HTTP_ACCEPT"] != null &&
            context.Request.ServerVariables["HTTP_ACCEPT"].ToLower().Contains("wap")) {
            return true;
        }
        //AND FINALLY CHECK THE HTTP_USER_AGENT 
        //HEADER VARIABLE FOR ANY ONE OF THE FOLLOWING
        if (context.Request.ServerVariables["HTTP_USER_AGENT"] != null) {
            //Create a list of all mobile types
            string[] mobiles =
                new[]
                {
                    "midp", "j2me", "avant", "docomo", 
                    "novarra", "palmos", "palmsource", 
                    "240x320", "opwv", "chtml",
                    "pda", "windows ce", "mmp/", 
                    "blackberry", "mib/", "symbian", 
                    "wireless", "nokia", "hand", "mobi",
                    "phone", "cdm", "up.b", "audio", 
                    "SIE-", "SEC-", "samsung", "HTC", 
                    "mot-", "mitsu", "sagem", "sony"
                    , "alcatel", "lg", "eric", "vx", 
                    "NEC", "philips", "mmm", "xx", 
                    "panasonic", "sharp", "wap", "sch",
                    "rover", "pocket", "benq", "java", 
                    "pt", "pg", "vox", "amoi", 
                    "bird", "compal", "kg", "voda",
                    "sany", "kdd", "dbt", "sendo", 
                    "sgh", "gradi", "jb", "dddi", 
                    "moto", "iphone"
                };

            //Loop through each item in the list created above 
            //and check if the header contains that text
            foreach (string s in mobiles) {
                if (context.Request.ServerVariables["HTTP_USER_AGENT"].
                                                    ToLower().Contains(s.ToLower())) {
                    return true;
                }
            }
        }

        return false;
    }

    protected void Page_PreInit(object sender, EventArgs e) {
        if (IsMobileBrowser()) {
            MasterPageFile = "ModelA.master";
        }    
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
}