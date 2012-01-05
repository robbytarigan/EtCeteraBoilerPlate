using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[Serializable]
public class Employee {
    public Employee(string empId) {
        //simulate looking up an employee
        this.ID = empId;
        this.FullName = "Joe Developer";
        this.Title = "ASP.NET Sr. Developer";
        this.Department = "Application Development";
    }
    public Employee() {
    }
    public string FullName { get; set; }
    public string ID { get; set; }
    public string Title { get; set; }
    public string Department { get; set; }
}