using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page,ICallbackEventHandler
{
    string _callbackArgs;
    protected void Page_Load(object sender, EventArgs e)
    {
        //register the name of the client-side function that will
        // be called by the server
        string callbackRef = Page.ClientScript.GetCallbackEventReference(
        this, "args", "ClientCallbackFunction", "");
        //define a function used by the client to call the server
        string callbackScript = String.Format(
        "function MyServerCall(args) {{ {0};}} ", callbackRef);
        //register the client function with the page
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(),
        "MyServerCall", callbackScript, true);
    }

    void ICallbackEventHandler.RaiseCallbackEvent(string eventArgument)  {
        _callbackArgs = eventArgument;
    }

    string ICallbackEventHandler.GetCallbackResult() {
        return _callbackArgs;
    }
}