<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userreg.aspx.cs" Inherits="UserRegistrationSimulation.userreg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration Simulation</title>
    <script type="text/javascript">
    function ValidatePassword(source, arguments) {
        var data = arguments.Value.split('');
        
        //start by setting false
        arguments.IsValid = false;
        
        //check length
        if (data.length < 6 || data.length > 14) 
            return;
        
        //check for uppercase, lowercase, and number
        var uc = false; var lc = false; var num = false;
        for (var c in data) {
            if (data[c] >= 'A' && data[c] <= 'Z') {
                uc = true;
            } else if (data[c] >= 'a' && data[c] <= 'z') {
                lc = true;
            } else if (data[c] >= '0' && data[c] <= '9') {
                num = true;
            }
            if (uc && lc && num) {
                arguments.IsValid = true;
                break;
            }
        }
    } 
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>User Registration</h1>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <br />
        <asp:Label ID="userNameLabel" runat="server" AssociatedControlID="UserNameTextBox" Text="User name:"></asp:Label>
        <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="UserNameRequiredFieldValidator" runat="server" ControlToValidate="UserNameTextBox" ErrorMessage="Your user name is required" ToolTip="Your user name is required">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="UserNameRegularExpressionValidator" runat="server" ControlToValidate="UserNameTextBox" ErrorMessage="Please use only letters and numbers with no spaces" ValidationExpression="\w{6,14}" ToolTip="Please use only letters and numbers with no spaces">*</asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="emailLabel" runat="server" AssociatedControlID="EmailTextBox" Text="Email:"></asp:Label>
        <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="Your email is required" ToolTip="Your email is required">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="Please use valid format for email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ToolTip="Please use valid format for email address">*</asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="passwordLabel" runat="server" AssociatedControlID="PasswordTextBox" Text="Password:"></asp:Label>
        <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="PasswordRequiredFieldValidator" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="A password is required" ToolTip="A password is required">*</asp:RequiredFieldValidator>
        <asp:CustomValidator ID="PasswordCustomValidator" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="Please enter 6-14 characters, including at least 1 uppercase letter, 1 lowercase letter, and 1 number" ToolTip="Please enter 6-14 characters, including at least 1 uppercase letter, 1 lowercase letter, and 1 number" ClientValidationFunction="ValidatePassword" onservervalidate="PasswordCustomValidator_ServerValidate">*</asp:CustomValidator>
        <br />
        <asp:Label ID="confirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPasswordTextBox" Text="Confirm password:"></asp:Label>
        <asp:TextBox ID="ConfirmPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ConfirmPasswordRequiredFieldValidator" runat="server" ControlToValidate="ConfirmPasswordTextBox" ErrorMessage="You must confirm your password" ToolTip="You must confirm your password">*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="ConfirmPasswordCompareValidator" runat="server" ControlToCompare="PasswordTextBox" ControlToValidate="ConfirmPasswordTextBox" ErrorMessage="Both password fields must match" ToolTip="Both password fields must match">*</asp:CompareValidator>
        <br />
        <br />
        <asp:Button ID="RegisterButton" runat="server" Text="Register" />
    
    </div>
    </form>
</body>
</html>
