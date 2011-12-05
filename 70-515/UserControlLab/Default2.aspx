<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<%@ Register Src="AddressUcTemplated.ascx" TagName="AddressUcTemplated" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:AddressUcTemplated ID="AddressUcTemplated1" runat="server" AddressType="Home">
            <LayoutTemplate>
                <h1>
                    Edit Home Address</h1>
                <table>
                    <tr>
                        <td>
                            Address Line 1:
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxAddress" runat="server" Text="<%#Container.Address.AddressLine1%>"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Address Line 2:
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxAddressLine2" runat="server" Text="<%#Container.Address.AddressLine2%>"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            City:
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxCity" runat="server" Text="<%#Container.Address.City%>"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            State:
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxState" runat="server" Text="<%#Container.Address.State%>"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Postal Code:
                        </td>
                        <td>
                            <asp:TextBox ID="TextBoxPostalCode" runat="server" Text="<%#Container.Address.PostalCode%>"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
        </uc1:AddressUcTemplated>
    </div>
    </form>
</body>
</html>
