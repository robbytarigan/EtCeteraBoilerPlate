<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddressUserControl.ascx.cs" Inherits="AddressUserControl" %>
<div>
    Address
    <br />
    <asp:TextBox ID="TextBoxAddress" runat="server" Width="325px" Height="80px" TextMode="MultiLine"></asp:TextBox>
    <div style="width: 450px">
        <div style="float: left; margin-right: 3px">
            City
            <br />
            <asp:TextBox ID="TextBoxCity" runat="server" Width="150"></asp:TextBox>
        </div>
        <div style="float: left; margin-right: 3px">
            State / Province
            <br />
            <asp:TextBox ID="TextBoxStateProv" runat="server" Width="80"></asp:TextBox>
        </div>
        <div style="float: left">
            Postal Code
            <br />
            <asp:TextBox ID="TextBoxPostalCode" runat="server" Width="70"></asp:TextBox>
        </div>
    </div>
    <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />
</div>
