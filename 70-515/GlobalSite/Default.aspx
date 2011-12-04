<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelWelcome" runat="server" Text="Label" meta:resourcekey="LabelWelcomeResource1"></asp:Label>
        <asp:DropDownList ID="DropDownListLang" runat="server" AutoPostBack="True" AppendDataBoundItems="true" meta:resourcekey="DropDownListLangResource1">
            <asp:ListItem Value="">Default</asp:ListItem>
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
