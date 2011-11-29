<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">    
    <div>
        <span style="color: #ffcc33"></span>
        <asp:Image ID="Image1" runat="server" ImageUrl="images/contoso-logo.gif" AlternateText="Contoso, Inc. logo" /><br />
        
        <asp:Panel ID="Panel1" runat="server" GroupingText="Shipping Address">
            <table>
                <tr>
                    <td style="width: 100px">                        
                        <asp:Label Text="<u>N</u>ame:" runat="server" AccessKey="N" AssociatedControlID="TextBox1" />
                    </td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox1" runat="server" TabIndex="1"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:Label Text="<u>A</u>ddress:" runat="server" AccessKey="A" AssociatedControlID="TextBox2" />
                    </td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox2" runat="server" TabIndex="2"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:Label Text="<u>C</u>ity:" runat="server" AccessKey="C" AssociatedControlID="TextBox3" />
                    </td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox3" runat="server" TabIndex="3"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:Label Text="<u>S</u>tate:" runat="server" AccessKey="S" AssociatedControlID="TextBox4" />
                    </td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox4" runat="server" TabIndex="4"></asp:TextBox></td>
                </tr>
            </table>
        </asp:Panel>

        <asp:Panel ID="Panel2" runat="server" GroupingText="Billing Address">
            <table>
                <tr>
                    <td style="width: 100px">
                        <asp:Label Text="Na<u>m</u>e:" runat="server" AccessKey="M" AssociatedControlID="TextBox5" />
                    </td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox5" runat="server" TabIndex="5"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:Label Text="A<u>d</u>dress:" runat="server" AccessKey="D" AssociatedControlID="TextBox6" />
                    </td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox6" runat="server" TabIndex="6"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:Label Text="<u>C</u>ity:" runat="server" AccessKey="C" AssociatedControlID="TextBox7" />
                    </td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox7" runat="server" TabIndex="7"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:Label Text="S<u>t</u>ate:" runat="server" AccessKey="T" AssociatedControlID="TextBox8" />
                    </td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox8" runat="server" TabIndex="8"></asp:TextBox></td>
                </tr>
            </table>
        </asp:Panel>
   
    </div>
    <div>
        <asp:Button ID="Button2" runat="server" Text="Continue Shopping" TabIndex="9" />
        <asp:Button ID="Button1" runat="server" Text="Checkout" TabIndex="10" />
    </div>

</asp:Content>
