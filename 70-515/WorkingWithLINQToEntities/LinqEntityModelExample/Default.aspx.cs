using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            PubsEntityModel.PubsEntities pubs = new PubsEntityModel.PubsEntities();

            var pubQuery = from p in pubs.Publishers
                            orderby p.PublisherName
                            select p;

            DropDownListPublishers.DataTextField = "PublisherName";
            DropDownListPublishers.DataValueField = "PublisherId";
            DropDownListPublishers.DataSource = pubQuery;
            DropDownListPublishers.DataBind();
        }
    }

    protected void ButtonShowTitles_Click(object sender, EventArgs e) {
        using (PubsEntityModel.PubsEntities pubs = new PubsEntityModel.PubsEntities()) {
            var titleQuery = from t in pubs.Titles
                             where t.PublisherId == DropDownListPublishers.SelectedValue
                             orderby t.TitleName
                             select t;

            GridViewTitles.DataSource = titleQuery;
            GridViewTitles.DataBind();
        }
    }
}