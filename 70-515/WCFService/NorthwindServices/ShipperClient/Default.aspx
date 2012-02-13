<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>EDIT SHIPPER INFORMATION</h1>
        <asp:Label Text="Enter Shipper Code" runat="server" AssociatedControlID="TextBoxShipperCode" />
        <asp:TextBox runat="server" ID="TextBoxShipperCode" />  
        <asp:Button Text="Get Shipper" runat="server" ID="ButtonGet" onclick="ButtonGet_Click" />
        <hr />

        <h2>EDIT SHIPPER DATA</h2>
        <asp:Label Text="Shipper Id" runat="server" AssociatedControlID="TextBoxShipperId" />
        <asp:TextBox runat="server" ID="TextBoxShipperId" />
        <br />

        <asp:Label Text="Company Name" runat="server" AssociatedControlID="TextBoxCompany" />
        <asp:TextBox runat="server" ID="TextBoxCompany" />
        <br />

        <asp:Label Text="Phone" runat="server" AssociatedControlID="TextBoxPhone" />
        <asp:TextBox runat="server" ID="TextBoxPhone" />
        <br />

        <asp:Button Text="Save" runat="server" ID="ButtonSave" onclick="ButtonSave_Click" />
    </div>
    </form>
</body>
</html>
