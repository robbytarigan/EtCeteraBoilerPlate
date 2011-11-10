<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Default.aspx.cs" Inherits="_Default" ViewStateMode="Disabled" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <div>
        <asp:Wizard ID="checkoutWizard" runat="server" ActiveStepIndex="0">
            <HeaderTemplate>
                Check out!
            </HeaderTemplate>
            <WizardSteps>
                <asp:WizardStep runat="server" title="Select Item(s)" StepType="Start">
                    Choose Items:<br />
                    <asp:CheckBoxList ID="itemCheckBoxList" runat="server">                    
                    </asp:CheckBoxList>
                
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Fill Dispatch Address" StepType="Step">
                    
                </asp:WizardStep>
                <asp:WizardStep runat="server" StepType="Finish" Title="Confirm">
                </asp:WizardStep>
                <asp:WizardStep runat="server" StepType="Complete" Title="Complete">
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </div>
</asp:Content>
