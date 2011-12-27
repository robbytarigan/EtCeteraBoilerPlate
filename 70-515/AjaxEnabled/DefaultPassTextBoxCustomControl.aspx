<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DefaultPassTextBoxCustomControl.aspx.cs" Inherits="DefaultPassTextBoxCustomControl" %>
<%@ Register Assembly="AjaxEnabled" Namespace="AjaxEnabled" TagPrefix="ajaxEnabled" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .weak
        {
            border: thin solid #FF0000;
        }
        .medium
        {
            border: thin solid #FFFF00;
        }
        .strong
        {
            border: medium solid #008000;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />    

    <div style="font-size: large; font-weight: bold">
        User Logon</div>
    <hr />
    <br />
    User Name:
    <br />
    <asp:TextBox ID="TextBoxUserName" runat="server" Width="200"></asp:TextBox>
    <br />
    Password:
    <br />
    <ajaxEnabled:PassTextBox ID="textBox1" runat="server" Width="200" TextMode="Password" WeakCssClass="weak" MediumCssClass="medium" StrongCssClass="strong"></ajaxEnabled:PassTextBox>
    
    <br />
    <input id="ButtonSubmit" type="button" value="Log On" />
</asp:Content>

