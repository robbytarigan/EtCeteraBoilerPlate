<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DefaultPassTextBox.aspx.cs" Inherits="DefaultPassTextBox" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .weak
        {
            border: thin solid #FF0000;
        }
        .medium
        {
            border: thin solid #FFFF00;
        }
        .strong
        {
            border: medium solid #008000;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Path="Scripts/PassTextBox.js" />
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
    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Width="200"></asp:TextBox>
    <asp:Label ID="LabelStrength" runat="server" Text=""></asp:Label>
    <br />
    <input id="ButtonSubmit" type="button" value="Log On" />

    <script type="text/javascript">
        var app = Sys.Application;
        app.add_init(appInit);

        function appInit(sender, args) {
            $create(AjaxEnabled.PassTextBox, { weakCssClass: 'weak', mediumCssClass: 'medium', strongCssClass: 'strong' }, null, null, $get('MainContent_TextBoxPassword'));
        }
    </script>

</asp:Content>

