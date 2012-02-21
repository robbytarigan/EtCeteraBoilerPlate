<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
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
</asp:Content>
