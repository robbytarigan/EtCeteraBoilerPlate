<%@ Page Title="Page 2" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Music.aspx.cs" Inherits="Default2" EnableViewState="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <h1>Page 2</h1>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Go to Page 1</asp:HyperLink>
</asp:Content>


