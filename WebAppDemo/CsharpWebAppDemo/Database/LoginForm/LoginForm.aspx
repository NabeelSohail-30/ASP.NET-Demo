<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="CsharpWebAppDemo.Database.LoginForm.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/StyleLogin.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <main>
        <div class="loginbox">
            <img src="img/Avatar.png" alt="" class="avatar">

            <div class="header">
                <h1>Login</h1>
            </div>

            <div>
                <label for="">User Email</label>         
                <asp:TextBox ID="TxtUserEmail" runat="server" TextMode="Email" CssClass="InputEmail"></asp:TextBox>
            </div>
            <div>
                <label for="">Password</label>       
                <asp:TextBox ID="TxtUserPass" runat="server" TextMode="Password" CssClass="InputEmail"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="LblLoginError" runat="server" Text="Login Failed, Incorrect Email or Password" Visible="False"></asp:Label>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Login" CssClass="SubmitBtn" OnClick="Button1_Click"/>
        </div>
    </main>
    </div>
    </form>
</body>
</html>
