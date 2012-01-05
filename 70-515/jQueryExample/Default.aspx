<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script src="Scripts/jquery-1.7.1.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Employee Lookup</h2>
    <hr />
    Enter Employee ID
    <br />
    <asp:TextBox ID="TextBoxEmpId" runat="server"></asp:TextBox>&nbsp;
    <br />
    <input type="button" id="ButtonSearch" runat="server" value="Search" />
    <div id="empDetails" style="display: none; margin-top: 40px">
        <h2>
            Employee Details</h2>
        <hr />
        <b>ID:</b>&nbsp;<span id="textId"></span><br />
        <b>Name:</b>&nbsp;<span id="textName"></span><br />
        <b>Title:</b>&nbsp;<span id="textTitle"></span><br />
        <b>Department:</b>&nbsp;<span id="textDepartment"></span><br />
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $("#MainContent_ButtonSearch").click(function () {
                $("#empDetails").hide("slow");

                var empId = $("#MainContent_TextBoxEmpId").val();

                $.ajax({
                    type: "POST",
                    dataType: "json",
                    contentType: "application/json",
                    url: "EmployeeService.asmx/GetEmployeeById",
                    data: "{'employeeId': '" + empId.toString() + "'}",
                    success: function (data) {
                        $("#textId").html(data.d.ID);
                        $("#textName").html(data.d.FullName);
                        $("#textTitle").html(data.d.Title);
                        $("#textDepartment").html(data.d.Department);

                        $("#empDetails").show("slow");
                    },
                    error: function () {
                        alert("Error calling the web service.")
                    }
                });

            });
        });
    </script>
</asp:Content>
