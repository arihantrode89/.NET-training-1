<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookiesDemo.aspx.cs" Inherits="StateManagementASP.NET.CookiesDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Store Cookie" OnClick="Button1_Click" />
        &nbsp &nbsp
        <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
        <br/><br />
        <asp:Button ID="Button2" runat="server" Text="Retrieve Cookie" OnClick="Button2_Click" />
        &nbsp &nbsp
        <asp:TextBox runat="server" ID="TextBox2"></asp:TextBox>

        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    </form>
    
</body>
</html>
