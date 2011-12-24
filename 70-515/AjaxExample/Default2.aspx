<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" ClientIDMode="Static" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <script type="text/javascript">
        function ClientCallbackFunction(args) {
            LabelMessage.innerText = args;
        }
    </script>
    <asp:DropDownList ID="DropDownListChoice" runat="server" OnChange="MyServerCall(DropDownListChoice.value)">
        <asp:ListItem>Choice 1</asp:ListItem>
        <asp:ListItem>Choice 2</asp:ListItem>
        <asp:ListItem>Choice 3</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="LabelMessage" runat="server"></asp:Label>
</asp:Content>
