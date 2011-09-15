<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label Text="Logon as" runat="server" />
    <asp:DropDownList ID="UserTypeDropDownList" runat="server" AutoPostBack="True">
        <asp:ListItem Value="R">Registered User</asp:ListItem>
        <asp:ListItem Value="G">Guest</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="UserNameLabel" runat="server" Text="User Name:" />
    <asp:TextBox runat="server" ID="UserNameTextBox" />  
    <br />
    <asp:Label ID="PasswordLabel" runat="server" Text="Password:" />
    <asp:TextBox runat="server" ID="PasswordTextBox" />
    <br />
    <asp:Button Text="Logon" runat="server" ID="LogonButton" onclick="LogonButton_Click" />
</asp:Content>

