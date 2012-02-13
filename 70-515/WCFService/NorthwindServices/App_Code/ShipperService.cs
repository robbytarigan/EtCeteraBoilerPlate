using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShipperService" in code, svc and config file together.
public class ShipperService : IShipperService {
    private string _cnnString = ConfigurationManager.ConnectionStrings["NwConnectionString"].ToString();

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
