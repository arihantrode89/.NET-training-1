<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Asp.NET.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Menu ID="Menu1" runat="server"  >
                 <DynamicItemTemplate>
                     <%# Eval("Text") %>
                 </DynamicItemTemplate>
                 <Items>
                     <asp:MenuItem Text="Login" Value="Home" NavigateUrl="Login.aspx" ></asp:MenuItem>
                     <asp:MenuItem Text="Register" Value="Login"></asp:MenuItem>
                 </Items>
             </asp:Menu>
        </div>
       
    </form>
</body>
</html>
