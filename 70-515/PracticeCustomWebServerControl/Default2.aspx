<%@ Page Language="C#" AutoEventWireup="false" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <pcl:LabeledTextBox ID="LabeledTextBox1" runat="server" Text="Hello world">
            <PromptTemplate>
                <label>Enter your name</label>                     
                <asp:TextBox runat="server" ID="test"  Text=<%# Container.Text %>/>  
            </PromptTemplate>
        </pcl:LabeledTextBox>
    
        
    </div>
    </form>
</body>
</html>
