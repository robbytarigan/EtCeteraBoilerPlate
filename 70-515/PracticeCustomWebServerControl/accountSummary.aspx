<%@ Page Language="C#" AutoEventWireup="false" CodeFile="accountSummary.aspx.cs" Inherits="accountSummary" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <pcl:AccountNumberQuester ID="AccountNumberQuester1" runat="server" />
    
        <asp:Label ID="messageLabel" runat="server" />
    </div>
    </form>
</body>
</html>
