<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="About.aspx.cs" Inherits="About" %>
<%@ OutputCache CacheProfile="TwentySecondsProfile" VaryByParam="none" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        About
    </h2>
    <p>
        Put content here.
    </p>
    <p>
        <asp:Literal ID="ParagraphLiteral" runat="server" />
        <br />
        <asp:Button Text="Submit" runat="server" ID="SubmitButton" onclick="SubmitButton_Click" />
    </p>
</asp:Content>
