<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <pcl:LabeledTextBox ID="LabeledTextBox1" runat="server" >
            <PromptTemplate>
                <asp:TextBox runat="server" ID="gds" Text='<%# Container.Text %>' />                
                <label>Label after text </label>
            </PromptTemplate>
        </pcl:LabeledTextBox>
    
    </div>
    </form>
</body>
</html>
