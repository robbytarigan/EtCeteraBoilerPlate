<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }

    void Application_BeginRequest(Object source, EventArgs e) {
        HttpApplication application = (HttpApplication)source;
        HttpContext context = application.Context;
        if (VirtualPathUtility.GetExtension(
        context.Request.FilePath) == ".aspx") {
            System.Diagnostics.EventLog eLog = new System.Diagnostics.EventLog();
            eLog.Source = "Robby1 Application";
            eLog.WriteEntry("Begin from Global.asax .aspx request :: " +
            DateTime.Now.ToLongDateString() + " :: " +
            context.Server.MachineName,
            System.Diagnostics.EventLogEntryType.Information);
        }
    }
    void Application_EndRequest(Object source, EventArgs e) {
        HttpApplication application = (HttpApplication)source;
        HttpContext context = application.Context;
        if (VirtualPathUtility.GetExtension(
        context.Request.FilePath) == ".aspx") {
            System.Diagnostics.EventLog eLog = new System.Diagnostics.EventLog();
            eLog.Source = "Robby1 Application";
            eLog.WriteEntry("End from Global.asax .aspx request :: " +
            DateTime.Now.ToLongDateString() + " :: " +
            context.Server.MachineName,
            System.Diagnostics.EventLogEntryType.Information);
        }
    }
       
</script>
