using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;

/// <summary>
/// Summary description for Authors
/// </summary>
[WebService(Namespace = "http://rstarigan.com/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Authors  {
    private string _cnnString = ConfigurationManager.ConnectionStrings["PubsConnectionString"].ToString();

    public Authors () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod(CacheDuration = 300)]
    public DataTable GetAuthorTitles(string authorId) {
        StringBuilder sql = new StringBuilder();
        sql.Append("SELECT titles.title, titles.type, titles.price, ");
        sql.Append("titles.pubdate FROM titleauthor INNER JOIN titles ON ");
        sql.Append("titleauthor.title_id = titles.title_id ");
        if (authorId != "0")
            sql.Append("WHERE (titleauthor.au_id = @AuthorId) ");
        SqlConnection cnn = new SqlConnection(_cnnString);
        SqlCommand cmd = new SqlCommand(sql.ToString(), cnn);
        cmd.Parameters.Add("AuthorId", SqlDbType.VarChar, 11).Value = authorId;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        return ds.Tables[0];
    }
}
