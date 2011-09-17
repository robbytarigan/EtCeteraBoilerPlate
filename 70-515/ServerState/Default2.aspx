<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>
        Default Page 2
    </h2>
    <div>
        <asp:Label runat="server" ID="Label1" />
        <br />
        <asp:Label runat="server" ID="Label2" />
        <br />
        <asp:HyperLink NavigateUrl="Default.aspx" runat="server" ID="HyperLink1" Text="Go to other page" />
    </div>
</asp:Content>

