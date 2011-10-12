<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" Height="350px" Width="475px">
            <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Left" />
            <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
            <SideBarStyle BackColor="#7C6F57" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
            <StepStyle BorderWidth="0px" ForeColor="#5D7B9D" />
            <WizardSteps>
                <asp:WizardStep runat="server" title="Select Office">
                    <asp:ImageMap ID="OfficeImageMap" runat="server" ImageUrl="~/Images/Floorplan.png">
                    </asp:ImageMap>
                    <br />
                    <br />
                    Office Selected:
                    <asp:Label ID="OfficeSelectedLabel" runat="server"></asp:Label>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Service Date">
                    Select Service Date:<br />
                    <asp:Calendar ID="ServiceDateCalendar" runat="server"></asp:Calendar>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Summary">
                    <asp:Label ID="SummaryLabel" runat="server" Height="200px" Width="250px"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    
    </div>
    </form>
</body>
</html>
