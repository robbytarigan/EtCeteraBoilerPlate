<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShipperList.aspx.cs" Inherits="NorthwindClient.ShipperList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="shipperDataSource">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:BoundField DataField="ShipperId" HeaderText="ShipperId" SortExpression="ShipperId" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="shipperDataSource" runat="server" DataObjectTypeName="NorthwindClient.NwServices.Shipper" SelectMethod="GetShippers" TypeName="NorthwindClient.NwServices.ShipperServiceClient" UpdateMethod="SaveShipper"></asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
