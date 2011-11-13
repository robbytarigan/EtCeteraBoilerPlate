using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public class PictureItem {
    public string Text { get; set; }
    public string Path { get; set; }
}

public partial class _Default : System.Web.UI.Page
{    

    private const string PictureFolder = "picture";    

    private string[] ImageContentTypes = new string[] { "image/gif", "image/jpeg", "image/pjpeg", "image/png", "image/svg+xml", "image/tiff", "image/vnd.microsoft.icon" };

    private IEnumerable<PictureItem> GetPictureItems() {
        foreach (string s in Directory.GetFiles(Server.MapPath(PictureFolder))) {
            string fileName = Path.GetFileName(s);
            yield return new PictureItem { Path = ResolveUrl(String.Format("~/{0}/{1}", PictureFolder, fileName)), Text = fileName };
        }
    }

    protected override void OnLoadComplete(EventArgs e) {
        base.OnLoadComplete(e);
        pictureListView.DataSource = GetPictureItems();
        pictureListView.DataBind();
        
    }

    protected void uploadButton_Click(object sender, EventArgs e) {
        if (ImageContentTypes.Contains(pictureFileUpload.PostedFile.ContentType.ToLowerInvariant())) {
            pictureFileUpload.SaveAs(String.Format("{0}/{1}", Server.MapPath(PictureFolder), pictureFileUpload.FileName));
            
        }
        
    }
}