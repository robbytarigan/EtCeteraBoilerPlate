<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<%@ Register src="LogoWebPart.ascx" tagname="LogoWebPart" tagprefix="uc1" %>
<%@ Register src="CalendarWebPart.ascx" tagname="CalendarWebPart" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>My Web Part Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:WebPartManager ID="WebPartManager1" runat="server">
    </asp:WebPartManager>
    <div style="width: 700px">
        <asp:WebPartZone ID="WebPartZoneTop" runat="server" HeaderText="Top Zone" Style="width: 700px; height: auto">
            <ZoneTemplate>
                <uc1:LogoWebPart ID="LogoWebPart1" runat="server" title="Logo" />
            </ZoneTemplate>
        </asp:WebPartZone>
        <asp:WebPartZone ID="WebPartZoneLeft" runat="server" HeaderText="Left Zone" Style="width: 300px; float: left; height: 300px">
            <ZoneTemplate>
                <uc2:CalendarWebPart ID="CalendarWebPart1" runat="server" title="Calendar" />
            </ZoneTemplate>
        </asp:WebPartZone>
        <asp:WebPartZone ID="WebPartZoneCenter" runat="server" HeaderText="Center Zone" Style="width: 400px; float: right; height: 300px">
        </asp:WebPartZone>
        <asp:WebPartZone ID="WebPartZoneBottom" runat="server" HeaderText="Bottom Zone" Style="width: 700px; height: auto;">
        </asp:WebPartZone>
    </div>
    </form>
</body>
</html>
