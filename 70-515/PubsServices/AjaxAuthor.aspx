<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AjaxAuthor.aspx.cs" Inherits="PubsClient.AjaxAuthor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
            Get Author Page
        </h2>
        <asp:TextBox ID="TextBoxAuthId" runat="server"></asp:TextBox>
        <br />
        <input id="Button1" type="button" value="Get" onclick="GetAuthor()" />
        <hr />
        <asp:Label ID="LabelResults" runat="server" Text=""></asp:Label>

        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/Authors.asmx" />                
            </Services>
        </asp:ScriptManager>
    </div>
    <script type="text/javascript">
        function GetAuthor() {                        
            var val = document.getElementById("TextBoxAuthId");
            Authors.GetAuthor(val.value, FinishCallback, null, null);            
        }
        function FinishCallback(result) {
            var results = document.getElementById("LabelResults");
            if (result)
                results.innerHTML = result.FirstName + " " + result.LastName + "(City:" + result.City + ")";
            else
                results.innerHTML = "No result.";
        }
    </script>
    </form>
</body>
</html>
