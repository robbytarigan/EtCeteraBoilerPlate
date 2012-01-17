<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HighlighterTest.aspx.cs" Inherits="HighlighterTest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ASP.NET AJAX Behavior Sample</title>
    <style type="text/css">
        .LowLight
        {
            background-color: #EEEEEE;
        }
        
        .HighLight
        {
            background-color: #FFFFF0;
        }
        .LowLightButton
        {
            font-weight: normal;
            width: 100px;
        }
        
        .HighLightButton
        {
            font-weight: bold;
            width: 100px;
            background-color:transparent;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <div>
        <table border="0" cellpadding="2">
            <tr>
                <td>
                    <asp:Label runat="server" ID="Label1" AssociatedControlID="TextBox1">Name</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="Label2" AssociatedControlID="TextBox2">Phone</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="Label3" AssociatedControlID="TextBox3">E-mail</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" />
                </td>
            </tr>
        </table>
        <asp:Button runat="server" ID="Button1" Text="Submit Form" />
        <ajaxButton:FocusHighlighter id="FocusExtender1" runat="server" nohighlightcssclass="LowLight" highlightcssclass="HighLight" targetcontrolid="TextBox1" />
        <ajaxButton:FocusHighlighter id="FocusExtender2" runat="server" nohighlightcssclass="LowLight" highlightcssclass="HighLight" targetcontrolid="TextBox2" />
        <ajaxButton:FocusHighlighter id="FocusExtender3" runat="server" nohighlightcssclass="LowLight" highlightcssclass="HighLight" targetcontrolid="TextBox3" />
        <ajaxButton:FocusHighlighter id="FocusExtender4" runat="server" nohighlightcssclass="LowLightButton" highlightcssclass="HighLightButton" targetcontrolid="Button1" />
    </div>
    </form>
</body>
</html>
