using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShipperService" in both code and config file together.
[ServiceContract(Namespace = "")]
public interface IShipperService
{
    [OperationContract]    
    IEnumerable<Shipper> GetShippers();

    [OperationContract]
    Shipper GetShipper(int shipperId);

    [OperationContract]
    void SaveShipper(Shipper shipper);
}

[DataContract]
public class Shipper {
    [DataMember]
    public int ShipperId { get; set; }

    [DataMember]
    public string CompanyName { get; set; }

    [DataMember]
    public string Phone { get; set; }
}