<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div style="background-color: #ffffcc">
        <div>
        <span style="color: #ffcc33"></span>
        <asp:Image ID="Image1" runat="server" ImageUrl="images/contoso-logo.gif" /><br />
        <asp:Image ID="Image2" runat="server" ImageUrl="images/shipping-address.gif" /><table>
            <tr>
                <td style="width: 100px">
                    Name:</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Address:</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox2" runat="server" TabIndex="5"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    City:</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    State</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Image ID="Image3" runat="server" ImageUrl="images/billing-address.gif" /><br />
        <table>
            <tr>
                <td style="width: 100px">
                    Name:</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Address:</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    City:</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox7" runat="server" TabIndex="2"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    State</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
            </tr>
        </table>
    </div>
        <asp:Button ID="Button2" runat="server" Text="Continue Shopping" />
        <asp:Button ID="Button1" runat="server" Text="Checkout" />
    </div>

</asp:Content>
