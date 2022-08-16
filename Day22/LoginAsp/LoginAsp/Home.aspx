<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LoginAsp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    <title>Home Page</title>

</head>
<body>
    <nav class="navbar navbar-expand-sm navbar-light bg-light">
          <div class="container-fluid">
              <a class="navbar-brand" href="#"><img class="img-fluid" src="/static/images/logo.png" style="width:100px;height:30px"/></a>
          </div>
            <ul class="navbar-nav">
                <li class="nav-item mx-2">
                    <a class="nav-link active" href="#">Home</a>
                </li>
                <li class="nav-item mx-2">
                    <a class="nav-link active" href="Login.aspx">Login</a>
                </li>
                <li class="nav-item mx-2">
                    <a class="nav-link active" href="Register.aspx">Register</a>
                </li>
            </ul>
     </nav>
    
    <div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    
</body>
</html>
