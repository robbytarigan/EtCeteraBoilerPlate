using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

namespace PubsClient {
    public partial class Default : System.Web.UI.Page {
        private PubsService.Authors authorsWS = new PubsService.Authors();

        protected override void OnPreInit(EventArgs e) {
            base.OnPreInit(e);

            //authorsWS.Credentials = System.Net.CredentialCache.DefaultCredentials; 

            NetworkCredential networkCredential = new NetworkCredential("Robby&Tia", "tia", "ROBBYTIA-PC");
            CredentialCache credentialCache = new CredentialCache();
            credentialCache.Add(new Uri(authorsWS.Url), "Basic", networkCredential);
            authorsWS.Credentials = credentialCache;
        }

        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void ObjectDataSource1_ObjectCreating(object sender, ObjectDataSourceEventArgs e) {
            e.ObjectInstance = authorsWS;
        }

        
    }
}