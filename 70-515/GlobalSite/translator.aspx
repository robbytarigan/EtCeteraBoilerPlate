<%@ Page Language="C#" AutoEventWireup="false" CodeFile="translator.aspx.cs" Inherits="TranslatorPage" EnableViewState="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Translator for Default Page</h1>

        <asp:DropDownList ID="DropDownListLang" runat="server" AutoPostBack="True" AppendDataBoundItems="true">
            <asp:ListItem Value="">Choose Language</asp:ListItem>
        </asp:DropDownList>
        <br />

        <asp:PlaceHolder runat="server" ID="controlHolder" />  

        <br />
        <asp:Button Text="Submit" runat="server" ID="submitButton" />
    </div>
    </form>
</body>
</html>
