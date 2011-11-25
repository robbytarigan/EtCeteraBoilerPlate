<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GetName.ascx.cs" Inherits="GetName" %>

Hello, previously you use username <%= UserName %>
<br />
<asp:Label Text="Please type your name" runat="server" ID="NameLabel" />
<asp:TextBox runat="server" ID="NameTextBox" />
<asp:Button Text="Submit" runat="server" ID="SubmitButton" onclick="SubmitButton_Click" />