<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Db11.aspx.cs" Inherits="CsharpWebAppDemo.Database.Db11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="LoginForm/css/bootstrap.css">
    <link rel="stylesheet" href="LoginForm/css/StyleLogin.css">
</head>

<body>
    <form id="form1" runat="server">
    <div>
    <main>
        <div class="loginbox">
            
            <div class="header">
                <h1>Login</h1>
            </div>

            <div>
                <label for="">User Email</label>         
                <asp:TextBox ID="TxtUserEmail" runat="server" CssClass="InputEmail"></asp:TextBox>
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
