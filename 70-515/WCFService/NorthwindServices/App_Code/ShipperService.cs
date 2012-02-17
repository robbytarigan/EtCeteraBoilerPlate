using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShipperService" in code, svc and config file together.
[ServiceContract(Namespace = "")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class ShipperService : IShipperService {
    private string _cnnString = ConfigurationManager.ConnectionStrings["NwConnectionString"].ToString();

    [OperationContract]
    public IEnumerable<Shipper> GetShippers() {
        SqlCommand sqlCmd = new SqlCommand("SELECT shipperId, companyName, phone FROM shippers");
        using (SqlConnection sqlConn = new SqlConnection(_cnnString)) {
            sqlCmd.Connection = sqlConn;
            sqlConn.Open();

            SqlDataReader reader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read()) {
                yield return new Shipper { ShipperId = (int)reader["shipperId"], CompanyName = (string)reader["companyName"], Phone = (string)reader["phone"] };
            }
        }
    }

    public Shipper GetShipper(int shipperId) {
        StringBuilder sql = new StringBuilder();
        sql.Append("SELECT shipperId, companyName, phone ");
        sql.Append("FROM shippers WHERE (shipperId = @ShipperId) ");
        SqlConnection cnn = new SqlConnection(_cnnString);
        SqlCommand cmd = new SqlCommand(sql.ToString(), cnn);
        cmd.Parameters.Add("ShipperId", SqlDbType.Int, 0).Value = shipperId;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        Shipper s = new Shipper();
        s.ShipperId = shipperId;
        s.CompanyName = ds.Tables[0].Rows[0]["companyName"].ToString();
        s.Phone = ds.Tables[0].Rows[0]["phone"].ToString();
        return s;
    }

    public void SaveShipper(Shipper shipper) {
        StringBuilder sql = new StringBuilder();
        sql.Append("UPDATE Shippers set phone=@Phone, ");
        sql.Append("companyName=@CompanyName WHERE shipperId = @ShipperId ");
        SqlConnection cnn = new SqlConnection(_cnnString);
        SqlCommand cmd = new SqlCommand(sql.ToString(), cnn);
        cmd.Parameters.Add("Phone", SqlDbType.NVarChar, 24).Value =
        shipper.Phone;
        cmd.Parameters.Add("CompanyName", SqlDbType.NVarChar, 40).Value =
        shipper.CompanyName;
        cmd.Parameters.Add("ShipperId", SqlDbType.Int, 0).Value =
        shipper.ShipperId;
        cnn.Open();
        cmd.ExecuteNonQuery();
        cnn.Close();
    }
}
