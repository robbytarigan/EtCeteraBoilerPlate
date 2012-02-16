using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

public partial class _Default : System.Web.UI.Page
{
    //private PubsService.Authors authorsWS;

    protected void Page_PreInit(object sender, EventArgs e) {
        //NetworkCredential networkCredential = new NetworkCredential("Robby&Tia", "tia", "ROBBYTIA-PC");
        //CredentialCache credentialCache = new CredentialCache();
        //credentialCache.Add(new Uri(authorsWS.Url), "Basic", networkCredential);

        //authorsWS = new PubsService.Authors();
        //authorsWS.Credentials = System.Net.CredentialCache.DefaultCredentials; //credentialCache;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ObjectDataSource1_ObjectCreating(object sender, ObjectDataSourceEventArgs e) {
        //e.ObjectInstance = new PubsService.Authors().UseDefaultCredentials = true;   
    }
}