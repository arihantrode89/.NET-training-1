<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinqAspDemo.aspx.cs" Inherits="Linq_AspDemo.LinqAspDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListLinq" runat="server" SelectionMode="Multiple">
                <asp:ListItem>Green</asp:ListItem>
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
                <asp:ListItem>Yellow</asp:ListItem>
            </asp:ListBox>
            <br/>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <hr/><br/>

            <asp:Button ID="Button1" runat="server" Text="Select" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
