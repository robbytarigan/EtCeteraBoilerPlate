<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Default.aspx.cs" Inherits="_Default" ViewStateMode="Disabled" EnableViewState="false" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <div>
        <asp:Wizard ID="checkoutWizard" runat="server" onnextbuttonclick="checkoutWizard_NextButtonClick">
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
                    <asp:Label ID="billingAddressLabel" Text="Billing Address Line 1:" runat="server" AssociatedControlID="billingAddress1TextBox" />
                    <asp:TextBox runat="server" ID="billingAddress1TextBox" TextMode="MultiLine" Rows="5" />  
                    <br />
                    <asp:Label Text="Post Code" runat="server" ID="billingAddressPostCodeLabel" AssociatedControlID="billingAddressPostCodeTextBox" />
                    <asp:TextBox runat="server" ID="billingAddressPostCodeTextBox" />
                    <br />
                    
                    <asp:Label ID="shippingAddressSelectionLabel" Text="Shipping Address: " runat="server" />
                    <asp:RadioButtonList ID="shippingAddressDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="shippingAddressDropDownList_SelectedIndexChanged">
                        <asp:ListItem Value="1">Use Billing Address for Shipping Address</asp:ListItem>
                        <asp:ListItem Value="2">Provide Different Shiping Address</asp:ListItem>
                    </asp:RadioButtonList>                    
                    
                    <br />
                    <asp:MultiView ActiveViewIndex="-1" runat="server" ID="shippingAddressSelectionMultiView">
                        <asp:View runat="server">
                            Shipping address will be similar to Billing Address
                        </asp:View>
                        <asp:View runat="server">
                            <asp:Label ID="shippingAddressLabel" Text="Shipping Address Line 1:" runat="server" AssociatedControlID="shippingAddress1TextBox" />
                            <asp:TextBox runat="server" ID="shippingAddress1TextBox" TextMode="MultiLine" Rows="5" />  
                            <br />
                            <asp:Label Text="Post Code" runat="server" ID="shippingAddressPostCodeLabel" AssociatedControlID="shippingAddressPostCodeTextBox" />
                            <asp:TextBox runat="server" ID="shippingAddressPostCodeTextBox" />
                        </asp:View>
                    </asp:MultiView>                    
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
                    Billing Address:
                    <asp:Label ID="confirmationBillingAddressLabel" runat="server" />

                    <br />
                    Shipping Address
                    <asp:Label ID="confirmationShippingAddressLabel" runat="server" />
                </asp:WizardStep>
                <asp:WizardStep runat="server" StepType="Complete" Title="Complete">
                    Your item has been processed and will be delivered soon!
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </div>
</asp:Content>
