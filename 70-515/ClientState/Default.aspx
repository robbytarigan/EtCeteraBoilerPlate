<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
    <div>
        <asp:Label runat="server" ID="Label1" />
        <asp:HyperLink runat="server" ID="Hyperlink1" NavigateUrl="Default2.aspx" Text="Access Other Page" />
        <asp:Button runat="server" ID="Button1" Text="Submit" />
        <%--<asp:HiddenField ID="HiddenField1" runat="server" />--%>
    </div>
</asp:Content>
