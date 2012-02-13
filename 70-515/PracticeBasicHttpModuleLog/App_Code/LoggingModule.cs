using System;
using System.Web;
using System.Diagnostics;
public class LoggingModule : IHttpModule {
    public LoggingModule() {
    }
    public String ModuleName {
        get { return "LoggingModule"; }
    }
    public void Dispose() { }
    public void Init(HttpApplication context) {
        context.BeginRequest +=
        (new EventHandler(this.Application_BeginRequest));
        context.EndRequest +=
        (new EventHandler(this.Application_EndRequest));
    }
    private void Application_BeginRequest(Object source, EventArgs e) {
        HttpApplication application = (HttpApplication)source;
        HttpContext context = application.Context;
        if (VirtualPathUtility.GetExtension(
        context.Request.FilePath) == ".aspx") {
            EventLog eLog = new EventLog();
            eLog.Source = "Robby1 Application";
            eLog.WriteEntry("Begin .aspx request :: " +
            DateTime.Now.ToLongDateString() + " :: " +
            context.Server.MachineName,
            EventLogEntryType.Information);
        }
    }
    private void Application_EndRequest(Object source, EventArgs e) {
        HttpApplication application = (HttpApplication)source;
        HttpContext context = application.Context;
        if (VirtualPathUtility.GetExtension(
        context.Request.FilePath) == ".aspx") {
            EventLog eLog = new EventLog();
            eLog.Source = "Robby1 Application";
            eLog.WriteEntry("End .aspx request :: " +
            DateTime.Now.ToLongDateString() + " :: " +
            context.Server.MachineName,
            EventLogEntryType.Information);
        }
    }
}