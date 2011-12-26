<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script  type="text/javascript">
        function _OnKeyPress() {            
            var checker = new AjaxEnabled.PasswordStrengthComponent();

            var pass = document.getElementById("MainContent_TextBoxPassword").value;

            var strength = checker.returnPasswordStrength(pass);

            document.getElementById("MainContent_LabelStrength").innerHTML = strength;
        }
    </script>
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Path="Scripts/PasswordStrengthComponent.js" />
        </Scripts>
    </asp:ScriptManager>

    <div style="font-size: large; font-weight: bold">
        User Logon</div>
    <hr />
    <br />
    User Name:
    <br />
    <asp:TextBox ID="TextBoxUserName" runat="server" Width="200"></asp:TextBox>
    <br />
    Password:
    <br />
    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Width="200" onkeyup="_OnKeyPress()"></asp:TextBox>
    <asp:Label ID="LabelStrength" runat="server" Text=""></asp:Label>
    <br />
    <input id="ButtonSubmit" type="button" value="Log On" />
</asp:Content>
