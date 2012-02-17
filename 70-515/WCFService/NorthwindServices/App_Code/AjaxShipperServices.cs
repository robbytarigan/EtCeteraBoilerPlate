using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

[ServiceContract(Namespace = "")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class AjaxShipperServices
{
    private string _cnnString = ConfigurationManager.ConnectionStrings["NwConnectionString"].ToString();

	// To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
	// To create an operation that returns XML,
	//     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
	//     and include the following line in the operation body:
	//         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
    [OperationContract]
    [WebGet]
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

	// Add more operations here and mark them with [OperationContract]
}
