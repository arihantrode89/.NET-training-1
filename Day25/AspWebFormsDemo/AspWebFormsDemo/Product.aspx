<%@ Page Title="Product" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="AspWebFormsDemo.Product" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <%--me-auto mb-2 mb-lg-0--%>

    <h1>Product Page</h1>
    <nav class="navbar navbar-expand-sm bg-dark fixed-top ">
          <div class="container-fluid">
              <a runat="server" class="navbar-brand text-white" href="#">Forum</a>
            <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                <li class="nav-item dropdown mx-2">
                    <a class="nav-link text-white dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown">Product Categories</a>
                    <ul class="dropdown-menu" runat="server">
                        <li><a runat="server" class="dropdown-item" href="~/Food">Food</a></li>
                        <li><a runat="server" class="dropdown-item" href="~/Business">Business</a></li>
                        <li><a runat="server" class="dropdown-item" href="~/Artificial_Inteligence">Artificial Inteligence</a></li>
                    </ul>
                </li>
            </ul>
          </div>
     </nav>



    


    
    <%--<asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px" OnSelectionChanged="OnCalendarChange">
        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
        <DayStyle Width="14%" />
        <NextPrevStyle Font-Size="8pt" ForeColor="White" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
        <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
        <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
        <TodayDayStyle BackColor="#CCCC99" />
    </asp:Calendar>
    <br /><br />
    <asp:ListBox ID="ListBox1" runat="server" Height="127px" Width="437px"></asp:ListBox>
    <asp:Button ID="Clearbtn" runat="server" Text="Clear List" OnClick="ClearList"/>
    --%>
    
</asp:Content>
