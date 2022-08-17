<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Response_Redirect_demo.aspx.cs" Inherits="Response_Server_Demo.Response_Redirect_demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 60%;">
                <tr>
                    <td>Within Same Server</td>
                    <td><asp:Button ID="button1" runat="server" Text="Redirect.Response" OnClick="Response_Redirect_same"></asp:Button></td>
                    <td><asp:Button ID="button2" runat="server" Text="Server.Transfer" OnClick="Server_Transfer_same"></asp:Button></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Diffrent Server</td>
                    <td><asp:Button ID="button3" runat="server" Text="Redirect.Response" OnClick="Response_Redirect_diffrent"></asp:Button></td>
                    <td><asp:Button ID="button4" runat="server" Text="Server.Transfer" OnClick="Server_Transfer_diffrent"></asp:Button></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
