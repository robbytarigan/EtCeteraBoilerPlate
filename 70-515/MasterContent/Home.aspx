<%@ Page Title="" Language="C#" MasterPageFile="~/Professional.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
    <br />
    <asp:DropDownList ID="SitePrefDropDownList" runat="server" AutoPostBack="True">
        <asp:ListItem>Professional</asp:ListItem>
        <asp:ListItem>Colorful</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button ID="OKButton" runat="server" Text="Button" onclick="OKButton_Click" />
</asp:Content>

