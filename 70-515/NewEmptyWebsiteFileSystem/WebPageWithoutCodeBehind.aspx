<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    
    protected void Page_Load(object sender, EventArgs e) {
        if (IsPostBack)
            messageLiteral.Text = "This is a postback";
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Literal runat="server" ID="messageLiteral" />
    </div>
    <div>
        <asp:Button ID="Button1" Text="Postback" runat="server"/>
    </div>
    </form>
</body>
</html>
