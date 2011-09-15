using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public class Person {
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public partial class StoreToCache : System.Web.UI.Page
{

    public List<Person> GetPeople() {
        System.Threading.Thread.Sleep(1000);
        return new List<Person>() {
            new Person { FirstName= "Naruto", LastName="Uzumaki"},
            new Person { FirstName= "Sasuke", LastName="Uciha"},
            new Person { FirstName= "Gaara", LastName="Sand"},
            new Person { FirstName= "Tenten", LastName="Store"},
            new Person { FirstName= "Guy", LastName="Sense"},
            new Person { FirstName= "Jiraiya", LastName="Sake"},
            new Person { FirstName= "Tsunade", LastName="Sama"},
            new Person { FirstName= "Lee", LastName="Can"},
            new Person { FirstName= "Sakura", LastName="Red"},
            new Person { FirstName= "Pain", LastName="Relief"},
        };
    }

    protected void Page_Load(object sender, EventArgs e)
    {        
        if (Cache["People"] == null) {
            Cache["People"] = GetPeople();            
        }

        List<Person> people = (List<Person>)Cache["People"];

        foreach (Person p in people) {
            Response.Write(String.Format("{0} {1} <br />", p.FirstName, p.LastName));
        }
    }
}