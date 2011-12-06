<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="MyCustomControls" Namespace="MyCustomControls" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:StateListControl ID="StateListControl1" runat="server">
        </cc1:StateListControl>
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" onclick="ButtonSubmit_Click" />
        <br />
        <asp:Label ID="LabelSelected" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
