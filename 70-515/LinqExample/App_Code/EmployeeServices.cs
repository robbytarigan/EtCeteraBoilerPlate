using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Summary description for EmployeeServices
/// </summary>
public class EmployeeServices
{
    XElement _empXml = XElement.Load(HttpContext.Current.Server.MapPath("~/App_Data/employees.xml"));

    public EmployeeServices()
	{

	}

    public List<string> GetDepartments()    {
        var deptQuery = from emp in _empXml.Descendants("Employee")
                        group emp by emp.Element("Department").Value
                            into empGroup
                            select empGroup.First().Element("Department").Value;

        return deptQuery.ToList();
    }

    public List<Employee> GetEmployeesByDept(string department) {
        IEnumerable<Employee> empQuery = from emp in _empXml.Descendants("Employee")
                                         where emp.Element("Department").Value == department
                                         select new Employee {
                                             Id = emp.Element("ID").Value,
                                             Department = emp.Element("Department").Value,
                                             FirstName = emp.Element("FirstName").Value,
                                             LastName = emp.Element("LastName").Value,
                                             Location = emp.Element("Location").Value
                                         };
        return empQuery.ToList();
    }
}