<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateDemo.aspx.cs" Inherits="StateManagementASP.NET.ViewStateDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Value"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        &nbsp&nbsp&nbsp
        
        <asp:Button ID="Button2" runat="server" Text="Clear" OnClick="Button2_Click" />
        &nbsp
        <asp:Button ID="Button1" runat="server" Text="Display" OnClick="Button1_Click" />
        <br/><br/>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
