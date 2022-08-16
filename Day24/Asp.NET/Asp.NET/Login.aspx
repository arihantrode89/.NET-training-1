<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Asp.NET.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    <title>Login Page</title>
</head>
<body style="background-image:url('static/images/books.jpg');">


    <section class="my-5 pt-5">
        <div id="abc" class="container-md py-3 bg-white rounded-3" style="width:500px;">

            <img class="img-fluid mx-auto d-block py-0" src="static\images\logo.jpeg" style="width:150px;align-items:center"/>

            <form id="login" runat="server">
                <div class="row mb-2 px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox runat="server" class="form-control" ID="emailid" placeholder="Enter Email" type="email" />
                    </div>
                </div>
                <div class="row mb-2 px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox runat="server" class="form-control" id="password" placeholder="Enter Password" type="password" TabIndex="1" />
                    </div>
                </div>
                <div class="row mb-2 px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox runat="server" class="form-check-input" type="checkbox" id="remember" TabIndex="2" />
                        <asp:label runat="server" class="form-check-label">Remember Me</asp:label>

                    </div>
                </div>
                <div class="mx-auto d-grid col-3">
                    <asp:Button runat="server" id="loginbtn" Class="btn btn-primary btn-md mb-2" type="submit" Text="Login" OnClick="Loginbtn_click" TabIndex="3"></asp:Button>
                </div>
            </form>
        </div>
        
    <asp:Label runat="server" ID="label1" Text="Label"></asp:Label>
    </section>
</body>
</html>
