<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
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
</asp:Content>
