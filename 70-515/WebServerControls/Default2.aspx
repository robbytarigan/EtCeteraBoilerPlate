<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="NameLabel" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="AddButton" runat="server" Text="Add" />
        <br />
        <br />
        <asp:Literal ID="ShippingTypeLiteral" runat="server" Text="Shipping Type"></asp:Literal>
        <br />
        <asp:RadioButtonList ID="ShipingTypeRadioButtonList" runat="server">
            <asp:ListItem>Standard</asp:ListItem>
            <asp:ListItem>Priority</asp:ListItem>
            <asp:ListItem>Urgent</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Literal ID="DestinationsLiteral" runat="server" Text="Destinations"></asp:Literal>
        <br />
        <asp:CheckBoxList ID="DestinationsCheckBoxList" runat="server">
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="ShipButton" runat="server" Text="Ship" />
        <br />
        <br />
        <asp:Label ID="ShippingConfirmationLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
