<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Image ID="Image1" SkinID="Logo" runat="server" />
    <br />
    <asp:TextBox ID="TextBoxUname" runat="server" CssClass="textBox"></asp:TextBox>
    <br />
    <asp:Button ID="ButtonSubmit" runat="server" Text="Hello" CssClass="button" OnClick="ButtonSubmit_Click" />
</asp:Content>
