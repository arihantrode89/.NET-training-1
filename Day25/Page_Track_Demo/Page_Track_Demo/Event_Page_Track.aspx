<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Event_Page_Track.aspx.cs" Inherits="Page_Track_Demo.Event_Page_Track" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Control Monitor</h1>
            <br />
            <br/>
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="ControlChanged"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Check" AutoPostBack="True" OnCheckedChanged="ControlChanged" />
            <br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Rd1" AutoPostBack="True" OnCheckedChanged="ControlChanged" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Rd2" AutoPostBack="True" OnCheckedChanged="ControlChanged" />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="166px" Width="395px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="ClearListBox" />
            <input id="Text1" type="text" runat="server" />
        </div>
    </form>
    
</body>
</html>
