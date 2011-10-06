<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" ViewStateMode="Disabled" %>
<%@ Register Namespace="Samples.AspNet.CS.Controls" TagPrefix="ctl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="resultLabel" runat="server" />

        <ctl:IndexButton runat="server" id="test1" Text="Test"></ctl:IndexButton>

        <asp:Button Text="Submit" runat="server" ID="LookButton" onclick="LookButton_Click" />
    </div>
    </form>
</body>
</html>
