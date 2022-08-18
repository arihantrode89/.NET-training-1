<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataSourceSample.aspx.cs" Inherits="ObjectDataSource_ControlsDemo.DataSourceSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="state" runat="server"></asp:TextBox>
            <br/><br/>

            <%-- Grid Views --%>
            <asp:GridView runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                </Columns>
            </asp:GridView>
            <%-- Object Data Source --%>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAuthorbyState" TypeName="ObjectDataSource_ControlsDemo.Publisher">
                <SelectParameters>
                    <asp:ControlParameter ControlID="state" Name="state" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <br/>

            <%-- Data list --%>
            <asp:DataList runat="server" DataSourceID="ObjectDataSource1">
                <ItemTemplate>
                    Name:
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    <br />
                    LastName:
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:DataList>

            <asp:DetailsView runat="server" Height="89px" Width="278px" AutoGenerateRows="False" DataSourceID="ObjectDataSource1">
                <Fields>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                </Fields>
            </asp:DetailsView>
        </div>
    </form>
</body>
</html>
