using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;
using System.Web.Script.Services;

/// <summary>
/// Summary description for Authors
/// </summary>
[WebService(Namespace = "http://rstarigan.com/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class Authors  {
    private static string ConvertToString(object obj) {
        return obj == DBNull.Value ? null : Convert.ToString(obj);
    }

    private string _cnnString = ConfigurationManager.ConnectionStrings["PubsConnectionString"].ToString();

    public Authors() {

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

    [WebMethod]
    public Author GetAuthor(string authorId) {
        SqlCommand sqlCmd = new SqlCommand(@"
SELECT au_lname, au_fname, phone, address, city, state, zip, contract
FROM            authors
WHERE au_id = @au_id");

        sqlCmd.Parameters.Add("au_id", SqlDbType.VarChar, 11).Value = authorId;

        using (SqlConnection sqlConn = new SqlConnection(_cnnString)) {
            sqlCmd.Connection = sqlConn;
            sqlConn.Open();

            SqlDataReader reader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (reader.Read()) {
                return new Author() {
                    AuthorID = authorId, LastName = (string)reader["au_lname"], FirstName = (string)reader["au_fname"], Phone = (string)reader["phone"],
                    Address = ConvertToString(reader["address"]), City = ConvertToString(reader["city"]), State = ConvertToString(reader["state"]), 
                    Zip = ConvertToString(reader["zip"]), Contract = Convert.ToBoolean(reader["contract"])
                };
            }
        }

        return null;
    }

    [WebMethod]
    public void UpdateAuthor(Author author) {
        SqlCommand sqlCmd = new SqlCommand(@"
UPDATE       authors
SET                au_lname = @au_lname, au_fname = @au_fname, phone = @phone, address = @address, city = @city, state = @state, zip = @zip, contract = @contract
WHERE au_id=@au_id ");

        sqlCmd.Parameters.Add("au_id", SqlDbType.VarChar, 11).Value = author.AuthorID;
        sqlCmd.Parameters.Add("au_lname", SqlDbType.VarChar, 40).Value = author.LastName;
        sqlCmd.Parameters.Add("au_fname", SqlDbType.VarChar, 20).Value = author.FirstName;
        sqlCmd.Parameters.Add("phone", SqlDbType.Char, 12).Value = author.Phone;
        sqlCmd.Parameters.Add("address", SqlDbType.VarChar, 40).Value = author.Address;
        sqlCmd.Parameters.Add("city", SqlDbType.VarChar, 20).Value = author.City;
        sqlCmd.Parameters.Add("state", SqlDbType.Char, 2).Value = author.State;
        sqlCmd.Parameters.Add("zip", SqlDbType.Char, 5).Value = author.Zip;
        sqlCmd.Parameters.Add("contract", SqlDbType.Bit).Value = author.Contract;

        using (SqlConnection sqlConn = new SqlConnection(_cnnString)) {
            sqlCmd.Connection = sqlConn;
            sqlConn.Open();

            sqlCmd.ExecuteNonQuery();
        }
    }

}
