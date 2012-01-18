using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for JpegHandler
/// </summary>
public class JpegHandler : IHttpHandler
{
	public JpegHandler()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    bool IHttpHandler.IsReusable {
        get { return false; }
    }

    void IHttpHandler.ProcessRequest(HttpContext context) {
        context.Response.ContentType = "image/jpeg";

        HttpRequest Request = context.Request;
        HttpResponse Response = context.Response;

        if (Request.RawUrl.ToLowerInvariant().Contains("jellyfish.jpg")) {
            Response.TransmitFile(Request.PhysicalApplicationPath + "/Images/Jellyfish.jpg");
        } else if (Request.RawUrl.ToLowerInvariant().Contains("koala.jpg")) {
            Response.TransmitFile(Request.PhysicalApplicationPath + "/Images/Koala.jpg");
        } else {
            Response.Write("File not found");
        }
    }
}