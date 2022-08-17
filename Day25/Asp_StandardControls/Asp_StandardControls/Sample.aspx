<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample.aspx.cs" Inherits="Asp_StandardControls.Sample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    <title>Sample Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <section class="py-3 px-3">
            <div class="container-md py-3" style="width:500px;">
                <div class="row mb-2 py-2 px-2">
                    <div class="col py-2 px-2">
                        <asp:Label ID="CustomerIdlable" runat="server" Text="Customer ID"></asp:Label>
                        <asp:TextBox ID="CustomerId" runat="server" CssClass="ml-2" Height="34px" Width="241px"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-2 py-2 px-2">
                    <div class="col py-2 px-2">
                        <asp:Label ID="CustomerNamelabel" runat="server" Text="Customer Name"></asp:Label>
                        <asp:TextBox ID="CustomerName" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-2 px-2 py-2">
                    <div class="col py-2 px-2">
                        <asp:Label ID="Addresslable" runat="server" Text="Address"></asp:Label>
                        <asp:TextBox ID="Address" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-2 py-2 px-2">
                    <div class="col py-2 px-2">
                        <asp:Label ID="Phonelable" runat="server" Text="Phone"></asp:Label>
                        <asp:TextBox ID="Phone" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-2 py-2 px-2">
                    <div class="col py-2 px-2">
                        <asp:Label ID="Label1" runat="server" Text="Drop"></asp:Label>
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="195px">
                            <asp:ListItem>Cus1</asp:ListItem>
                            <asp:ListItem>Cus2</asp:ListItem>
                            <asp:ListItem>Cus3</asp:ListItem>
                            <asp:ListItem>Cus4</asp:ListItem>
                            <asp:ListItem>Cus5</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="mx-auto d-grid col">
                    <asp:Button ID="Button1" runat="server" Text="Submit"/>
                </div>

            </div>
                
            
        </section>
    </form>
</body>
</html>
