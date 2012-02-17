<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JsonClient.aspx.cs" Inherits="JsonClient" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">    
    <div>
        <div id="content">
            Loading...
        </div>
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
            <asp:ServiceReference Path="~/AjaxShipperServices.svc" />
        </Services>
    </asp:ScriptManager>
    <script type="text/javascript">
        function onSuccess(result) {
            var content = document.getElementById("content");
            var resultString = '';
            for (var i = 0; i < result.length; i++) {
                resultString += String.format("<tr><td>{0}</td> <td>{1}</td> <td>{2}</td></tr> ", result[i].ShipperId, result[i].Phone, result[i].CompanyName);
                                
            }

            content.innerHTML = "<table><tr><td>Shipper ID</td> <td>Company Name</td> <td>Phone</td></tr> " + resultString + " </table>";
        }

        function onFail(result) {
            alert(result);
        }

        function loading() {            


            var service = new AjaxShipperServices();
            service.GetShippers(onSuccess, onFail, null);
            
                        

        }

        loading();
    </script>
    </form>        
</body>
</html>
