using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonUpdate_Click(object sender, EventArgs e) {
        EmployeeServices empSrv = new EmployeeServices();
        GridViewEmployees.DataSource = empSrv.GetEmployeesByDept(DropDownListDepts.SelectedItem.Text);
        GridViewEmployees.DataBind();
    }
}
