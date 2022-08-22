<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinqForm.aspx.cs" Inherits="LinqAssesment.LinqForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
                <asp:ListItem>Green</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
                <asp:ListItem>Black</asp:ListItem>
            </asp:ListBox>

            <br/><br/>

            <asp:ListBox ID="ListBox2" runat="server" SelectionMode="Multiple">
                <asp:ListItem>Yellow</asp:ListItem>
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Violet</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
                <asp:ListItem>White</asp:ListItem>
            </asp:ListBox>

            <br/><br/>

            <asp:Button ID="Button1" runat="server" Text="Merge" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
