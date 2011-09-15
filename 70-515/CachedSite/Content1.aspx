<%@ Page Title="" Language="C#" MasterPageFile="~/ModelA.master" AutoEventWireup="true" CodeFile="Content1.aspx.cs" Inherits="Content1" %>

<%@ Register src="Setting.ascx" tagname="Setting" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>
        This is a content 1 (One).
    </h2>

    <div>
        <asp:Label Text="Choose Layout" runat="server" />
        <asp:DropDownList runat="server" ID="MasterDropDownList">
            <asp:ListItem Text="ModelA" Value="ModelA" />
            <asp:ListItem Text="Site" Value="Site" />
        </asp:DropDownList>
        <asp:Button Text="Select Layout" runat="server" id="SelectButton" onclick="SelectButton_Click" />
        
    </div>
    <div>
        <uc1:Setting ID="ColorSetting" runat="server" />
    </div>
</asp:Content>

