<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label runat="server" ID="Label1" />
    <asp:HyperLink runat="server" ID="Hyperlink1" NavigateUrl="Default.aspx" Text="Access Other Page" />
    <asp:Button runat="server" ID="Button1" Text="Submit" />
</asp:Content>

