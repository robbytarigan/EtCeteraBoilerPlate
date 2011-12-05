using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Summary description for AddressUcContainer
/// </summary>
public class AddressUcContainer : Control, INamingContainer {
    public AddressUcContainer(Address address) {
        this.Address = address;
    }
    public Address Address { get; set; }
}