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
        var joinQuery = from p in Container.Products
                        join c in Container.Companies on p.CompanyId equals c.CompanyId
                        select new { c.CompanyName, p.Name, p.Price };

        joinGrid.DataSource = joinQuery;
        joinGrid.DataBind();

        var groupQuery = from p in Container.Products
                         group p by p.CompanyId into pg
                         join c in Container.Companies on pg.Key equals c.CompanyId
                         select new { c.CompanyName, Count= pg.Count()};

        groupGrid.DataSource = groupQuery;
        groupGrid.DataBind();
                         
    }
}