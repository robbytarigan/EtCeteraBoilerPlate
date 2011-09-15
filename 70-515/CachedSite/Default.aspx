<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ OutputCache Duration="20" VaryByParam="ctl00$MainContent$ChoiceDropDownList" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
    <p>
        <asp:Literal Text="text" runat="server" ID="OtherMessageLiteral" />
    </p>
    <div>
        <asp:Label ID="ChosenLabel" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:DropDownList ID="ChoiceDropDownList" runat="server">
            <asp:ListItem>One</asp:ListItem>
            <asp:ListItem>Two</asp:ListItem>
            <asp:ListItem>Three</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="SubmitButton" runat="server" Text="OK" onclick="SubmitButton_Click" />
    </div>
</asp:Content>
