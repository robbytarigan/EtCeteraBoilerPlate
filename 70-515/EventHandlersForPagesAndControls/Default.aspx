<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AdRotator ID="AdRotator1" runat="server" DataSourceID="ObjectDataSource1" />
    
    </div>
    <asp:BulletedList ID="BulletedList1" runat="server">
    </asp:BulletedList>
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <asp:CheckBox ID="CheckBox1" runat="server" />
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
    </asp:CheckBoxList>
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:HiddenField ID="HiddenField1" runat="server" />
    <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
    <asp:Image ID="Image1" runat="server" />
    <asp:ImageButton ID="ImageButton1" runat="server" />
    </form>
</body>
</html>
