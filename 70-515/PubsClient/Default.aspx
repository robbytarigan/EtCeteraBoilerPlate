<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="Default.aspx.cs" Inherits="PubsClient.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAuthorTitles" TypeName="PubsClient.PubsService.Authors" DataObjectTypeName="PubsClient.PubsService.Author" UpdateMethod="UpdateAuthor" onobjectcreating="ObjectDataSource1_ObjectCreating" >
            <SelectParameters>
                <asp:QueryStringParameter Name="authorId" QueryStringField="auId" Type="String" DefaultValue="0" />
            </SelectParameters>
        </asp:ObjectDataSource>

        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
