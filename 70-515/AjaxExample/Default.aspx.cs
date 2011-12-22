using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    private static string[] ImageFileNames;
    private static Random rand = new Random();

    static _Default() {
        ImageFileNames = Directory.EnumerateFiles(HttpContext.Current.Server.MapPath("~/Images")).Select(s=> Path.GetFileName(s)).ToArray();
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonSave_Click(object sender, EventArgs e) {
        SqlDataSourceNwd.Insert();
        GridView1.DataBind();

        TextBoxCompany.Text = "";
        TextBoxContact.Text = "";
        TextBoxCity.Text = "";
        TextBoxPhone.Text = "";
        System.Threading.Thread.Sleep(2000);
    }
    
    protected void Timer1_Tick(object sender, EventArgs e) {
        int nextFileIdx = rand.Next(ImageFileNames.Length - 1);

        advertisementImage.ImageUrl = Page.ResolveUrl(String.Format("~/Images/{0}", ImageFileNames[nextFileIdx]));
    }
}
