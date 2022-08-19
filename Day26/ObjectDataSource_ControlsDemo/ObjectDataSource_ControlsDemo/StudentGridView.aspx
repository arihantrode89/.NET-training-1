<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentGridView.aspx.cs" Inherits="ObjectDataSource_ControlsDemo.StudentGridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    <title>Student</title>
</head>
<body>
   <section class="py-3 px-3">
         <div class="container-md py-3" style="width:500px;">
            <form id="form1" runat="server">
                
                <div class="row mb-2 py-2 px-2">
                    <div class="col py-2">
                        <asp:TextBox ID="Name" runat="server" placeholder="Enter Student Name" Width="430px"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-2 px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox ID="email" runat="server" placeholder="Enter Student Email" Width="430px"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-2 py-2 px-2">
                    <div class="col py-2">
                        <asp:TextBox ID="Phone" runat="server" placeholder="Enter Student Phone" Width="430px"></asp:TextBox>
                    </div>
                </div>

                <div class="row mb-2 py-2 px-2">
                    <div class="col py-2">
                        <asp:TextBox ID="dept" runat="server" placeholder="Enter Student Department" Width="430px"></asp:TextBox>
                    </div>
                </div>
                <div class="mx-auto d-grid col-3">
                    <asp:Button ID="Add" runat="server" Text="Add" OnClick="AddStudent" />
                </div>


                <br/><hr/>



                <div class="container" runat="server">
                <asp:GridView ID="gridview1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnRowDeleted="gridview1_RowDeleted" AutoGenerateEditButton="True" OnRowUpdating="gridview1_RowUpdating">
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Select" ShowHeader="True" Text="Select" />
                        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                        <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                        <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
                        <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete" ShowHeader="True" Text="Delete" />
                        <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Edit" ShowHeader="True" Text="Edit" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:trainingConnectionString %>" SelectCommand="SELECT * FROM [StudentGridView]" DeleteCommand="Delete from StudentGridView where Id=@Id" ></asp:SqlDataSource>
                </div>

                <br/>
                    <asp:Label ID="del_label" runat="server" Text=""></asp:Label>
                <br/>
                <div class="row">
                <div class="mx-auto d-grid col-3">
                    <asp:Button ID="delete" runat="server" Text="Delete" OnClick="DeleteStudent" />
                </div>

                <div class="mx-auto d-grid col-3">
                    <asp:Button ID="update" runat="server" Text="Update"/>
                </div>
                </div>
                  
           </form>

    </div>
       
    
      </section>

    
</body>
</html>
