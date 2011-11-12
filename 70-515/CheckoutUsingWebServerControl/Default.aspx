<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Default.aspx.cs" Inherits="_Default" ViewStateMode="Disabled" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <div>
        <asp:Wizard ID="checkoutWizard" runat="server" ActiveStepIndex="0" onnextbuttonclick="checkoutWizard_NextButtonClick">
            <HeaderTemplate>
                Check out!
            </HeaderTemplate>
            <WizardSteps>
                <asp:WizardStep runat="server" title="Select Item(s)" StepType="Start">
                    Choose Items:<br />
                    <asp:CheckBoxList ID="itemCheckBoxList" runat="server" DataTextField="Name" DataValueField="Id">                    
                    </asp:CheckBoxList>
                    
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Specify Quantity" StepType="Step">
                    Specify Quantity: <br />
                    <asp:PlaceHolder ID="quantityItemPlaceHolder" runat="server"></asp:PlaceHolder>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Fill Dispatch Address" StepType="Step">
                    <asp:Label Text="Despatch Address:" runat="server" />
                    <asp:TextBox runat="server" ID="despatchAddressTextBox" TextMode="MultiLine" Rows="5" />  
                </asp:WizardStep>
                <asp:WizardStep runat="server" StepType="Finish" Title="Confirm">
                    Detail of your items:
                    <br />
                    <asp:Table ID="confirmationItemTable" runat="server">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Quantity</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Unit Price</asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    </asp:Table>
                    <br />
                    <asp:Label ID="confirmationDespatchAddressLabel" runat="server" />
                </asp:WizardStep>
                <asp:WizardStep runat="server" StepType="Complete" Title="Complete">
                    Your item has been processed and will be delivered soon!
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </div>
</asp:Content>
