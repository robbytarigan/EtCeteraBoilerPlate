<%@ Page Language="C#" AutoEventWireup="false" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<%@ Register src="AccountControl.ascx" tagname="AccountControl" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:AccountControl ID="accountUC" runat="server" AccountNumberLabel="Account number please" AccountLetterLabel="Account letter please" />
    
    </div>
    </form>
</body>
</html>
