﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NextPage.aspx.cs" Inherits="StateManagementASP.NET.NextPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Get Name" OnClick="Button1_Click" />
            <br/><br />
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
