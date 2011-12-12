<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TracingAjax.aspx.cs" Inherits="TracingAjax" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AJAX Trace Example</title>
    <script type="text/javascript">
        function button1_onclick() {
            Sys.Debug.trace("Button1 clicked");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <input id="Button1" type="button" value="button" onclick="button1_onclick()" />

        <asp:TextBox ID="TraceConsole" runat="server" TextMode="MultiLine" Rows="20" Columns="400"></asp:TextBox>
    </div>
    </form>
</body>
</html>
