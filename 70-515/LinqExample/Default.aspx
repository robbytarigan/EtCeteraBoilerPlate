<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" ClientIDMode="Static" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
        <h2>
            View Employees by Department
        </h2>
        Select a Department<br />
        <asp:DropDownList ID="DropDownListDepts" runat="server" DataSourceID="ObjectDataSourceDepts">
        </asp:DropDownList>
        <asp:Button ID="ButtonUpdate" runat="server" Text="Update" OnClick="ButtonUpdate_Click" />
        <hr />
        <asp:GridView ID="GridViewEmployees" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSourceDepts" runat="server" SelectMethod="GetDepartments" TypeName="EmployeeServices"></asp:ObjectDataSource>
    </div>

    <div>
        <h2>
            View Employees by Department with AJAX
        </h2>

        <div id="employeeArea">                               
                
        </div>

        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/AjaxService.svc" />
            </Services>
        </asp:ScriptManager>

        <script type="text/javascript" src="Scripts/jquery-1.4.1.js"></script>
        <script type="text/javascript">
            var service = new AjaxService();

            $("#DropDownListDepts").change(function () {
                service.GetEmployeesByDept($("#DropDownListDepts").val(),
                    function (result) {
                        var str = "<div> <div>Data added on " + new Date().toLocaleString() + "</div> \
             <table> \
                <thead> \
                    <tr> \
                        <th>First Name</th> \
                        <th>Last Name</th> \
                        <th>Department</th> \
                        <th>Location</th> \
                    </tr> \
                </thead> \
                <tbody>";
                        for (var i = 0; i < result.length; result++) {
                            str += "<tr> <td>" + result[i].FirstName + "</td><td>" + result[i].LastName + "</td><td>" + result[i].Location + "</td><td>" + result[i].Location + "</td> </tr>"
                        }

                        str += "</tbody> \
            </table> </div>"

                        $("#employeeArea").prepend(str);
                    },
                    function (result) {
                        alert(result);
                    }
                )
            });
        </script>

    </div>
</asp:Content>
