﻿<%@ Page Language="C#" AutoEventWireup="false" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Panel runat="server" ID="uploadPanel">  
        <asp:FileUpload ID="pictureFileUpload" runat="server" />
        <asp:Button ID="uploadButton" runat="server" Text="Upload" />
    </asp:Panel>
    <asp:Panel runat="server" ID="displayPanel">
        <asp:Image ID="pictureImage" runat="server" />
    </asp:Panel>
    </form>
</body>
</html>
