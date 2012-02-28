using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Container
/// </summary>
public class Container
{
    public static readonly Company[] Companies = new Company[] {
        new Company {CompanyId = 1, CompanyName = "No More Problem Inc"},
        new Company{ CompanyId=2, CompanyName="Jalan-jalan"},
        new Company { CompanyId = 3, CompanyName = "Redwordk plc"}
    };

    public static readonly Product[] Products = new Product[] {
        new Product { CompanyId=1, Name="Hat", Price= 1.23M},
        new Product { CompanyId=2, Name="Shirt", Price = 2.08M},
        new Product { CompanyId =1, Name = "Trousers", Price = 3.56M},
        new Product{ CompanyId =1, Name="Shoes", Price = 4.76M},
        new Product{CompanyId =2, Name="Bike", Price = 10.00M},
        new Product { CompanyId = 3, Name="Rice", Price = 7.49M}
    };
}

	