<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
            View Publisher Titles</h2>
        Select a publisher from the list:<br />
        <asp:DropDownList ID="DropDownListPublishers" runat="server">
        </asp:DropDownList>
        <asp:Button ID="ButtonShowTitles" runat="server" Text="Show Titles" OnClick="ButtonShowTitles_Click" />
        <hr />
        <asp:GridView ID="GridViewTitles" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
