<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" EnableViewState="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ValidationSummary ID="pageValidationSummary" runat="server" />
    <asp:Literal runat="server" ID="entryLiteral" />
    <div>
        <asp:Label Text="Account Number:" runat="server" ID="accountNumberLabel" AssociatedControlID="accountNumberTextBox" />
        <asp:TextBox runat="server" ID="accountNumberTextBox" />  
        <asp:RequiredFieldValidator EnableClientScript="false" ID="accountNumberRequiredFieldValidator" runat="server" ErrorMessage="Please specify account number." ToolTip="Please specify account number." ControlToValidate="accountNumberTextBox">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator EnableClientScript="false" ID="accountNumberRegularExpressionValidator" runat="server" ErrorMessage="Account number is not valid." ToolTip="Account number is not valid." ControlToValidate="accountNumberTextBox" ValidationExpression="^\d{1,7}$">*</asp:RegularExpressionValidator>
        <br />
        <asp:Label Text="Date of Birth:" runat="server" ID="birthDateLabel" AssociatedControlID="birthDateTextBox" />
        <asp:TextBox runat="server" ID="birthDateTextBox" />  
        <asp:RequiredFieldValidator EnableClientScript="false" ID="birthDateRequiredFieldValidator" runat="server" ErrorMessage="Please specify date of birth." ToolTip="Please specify date of birth." ControlToValidate="birthDateTextBox">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator EnableClientScript="false" ID="birthDateRegularExpressionValidator" runat="server" ErrorMessage="Date of birth is not valid." ToolTip="Date of birth is not valid." ControlToValidate="birthDateTextBox" ValidationExpression="^(([012][0-9])|3[01])/((0[0-9])|(1[12]))/((19|20)[0-9][0-9])$">*</asp:RegularExpressionValidator>
        <br />
        <asp:Button Text="Submit" runat="server" ID="submitButton" onclick="submitButton_Click" />
    </div>
    </form>
</body>
</html>
