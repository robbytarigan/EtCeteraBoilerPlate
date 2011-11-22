<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GetName.ascx.cs" Inherits="GetName" %>
<asp:Label Text="Please type your name" runat="server" ID="NameLabel" />
<asp:TextBox runat="server" ID="NameTextBox" />
<asp:Button Text="Submit" runat="server" ID="SubmitButton" onclick="SubmitButton_Click" />