<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LoginAsp.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
    <title>Register</title>
</head>
<body style="background-image:url('static/images/books.jpg');">
    
    <section class="my-1 pt-1">
        <div class="container-md py-3  rounded-3 bg-white " style="width:500px;">
            
            <img class="img-fluid mx-auto d-block py-0" src="static/images/logo.jpeg" style="width:150px;align-items:center"/>


            <form runat="server">
                <div class="row mb-2 px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox runat="server" class="form-control" type="text" id="firstname" placeholder="First Name" required/>
                    </div>

                    <div class="col py-2">
                        <asp:TextBox runat="server" class="form-control" type="text" id="lastname" placeholder="Last Name" required />
                    </div>
                </div>
                <div class="row mb-2 px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox runat="server" class="form-control" type="email" id="email" placeholder="Enter Email" required />
                    </div>
                </div>

                <div class="row mb-2 px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox runat="server" class="form-control" type="number" id="phone" placeholder="Enter Mobile" required />
                    </div>
                </div>

                <div class="row mb-2 px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox runat="server" class="form-control" type="password" id="password" placeholder="Enter Password" required />
                    </div>
                </div>

                <div class="row mb-2 px-2 py-2">
                    <div class="col py-2">
                        <asp:TextBox runat="server" class="form-control" type="password" id="cnf_password" placeholder="Confirm Password" required />
                    </div>
                </div>


                <div class="mx-auto d-grid col-3">
                    <asp:Button runat="server" id="Signup" Class="btn btn-primary btn-md mb-2" type="submit" Text="Sign Up" OnClick="Signup_Click"></asp:Button>
                </div>
            </form>
        </div>
    </section>
</body>
</html>
