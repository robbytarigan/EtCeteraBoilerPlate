<%@ Control Language="C#" AutoEventWireup="false" CodeFile="AccountControl.ascx.cs" Inherits="AccountControl" %>


<asp:Label ID="accountNumberLabel" runat="server" AssociatedControlID="accountNumberTextBox">Account Number</asp:Label>
<asp:TextBox ID="accountNumberTextBox" runat="server"></asp:TextBox>

<br />
<asp:Label ID="accountLetterLabel" runat="server" AssociatedControlID="accountLetterDropDownList">Account Letter</asp:Label>
<asp:DropDownList ID="accountLetterDropDownList" runat="server"></asp:DropDownList>

<br />
<asp:Button ID="continueButton" runat="server" Text="Continue   " onclick="continueButton_Click" />