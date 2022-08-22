<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="MondayAssesmentASP.BookDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    <title>Book Details</title>
</head>
<body>
    <section class="pt-4 py-4 rounded-5">
        <div class="container-md bg-light" style="width:500px;">

            <form id="form1" runat="server">
                <div class="row px-2 py-2 mt-4">
                    <div class="col py-2">
                        <asp:TextBox class="form-control" runat="server" ID="BookId" placeholder="Enter Book ID" ToolTip="Book Id"></asp:TextBox>
                    </div>
                </div>
                <div class="row px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox  class="form-control" runat="server" ID="BookName" placeholder="Enter Book Name" ToolTip="Book Name" ></asp:TextBox>
                    </div>
                </div>
                <div class="row px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox class="form-control" runat="server" ID="Author" placeholder="Enter Author Name" ToolTip="Author"></asp:TextBox>
                    </div>
                </div>
                <div class="row px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox class="form-control" runat="server" ID="Publisher" placeholder="Enter Publisher Name" ToolTip="Publisher"></asp:TextBox>
                    </div>
                </div>
                <div class="row px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox class="form-control" runat="server" ID="Price" placeholder="Enter Book Price" ToolTip="Price"></asp:TextBox>
                    </div>
                </div>
               
                <div class="mx-auto d-grid col-3">
                    <asp:Button runat="server" ID="Add" Text="Submit" class="btn btn-primary mb-2" OnClick="AddBookDetails" />
                </div>

                <br/><hr/><br/>

                <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting">
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete" ShowHeader="True" Text="Delete" />
                        <asp:TemplateField HeaderText="Edit">
                            <ItemTemplate>
                                <asp:Button ID="edit" runat="server" CausesValidation="false" CommandName="Edit" Text="Edit" />
                            </ItemTemplate>
                        <EditItemTemplate>
                                <asp:Button ID="update" runat="server" CausesValidation="false" CommandName="Update" Text="Update" />
                                 <asp:Button ID="cancel" runat="server" CausesValidation="false" CommandName="Cancel" Text="Cancel" />
                        </EditItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <PagerTemplate>
                        Edit<br />
                    </PagerTemplate>
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>

            </form>
        </div>
    </section>
</body>
</html>
