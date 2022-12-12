<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="LMSWeb.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link rel="stylesheet" href="CSS/bootstrap.css">
    <link rel="stylesheet" href="CSS/GlobalStyle.css">
    <link rel="stylesheet" href="CSS/StyleLogin.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <main>
        <div class="loginbox">
            <img src="Images/Avatar.png" alt="" class="avatar">
            <div class="header">
                <h1>Login</h1>
            </div>
            <div>
                <label for="">User Email</label>         
                <asp:TextBox ID="TxtUserEmail" runat="server" TextMode="Email" CssClass="InputEmail"></asp:TextBox>
                <asp:Label ID="LblEmailError" runat="server" Text="Please Enter Login Email" Visible="False"></asp:Label>
            </div>
            <div>
                <label for="">Password</label>       
                <asp:TextBox ID="TxtUserPass" runat="server" TextMode="Password" CssClass="InputEmail"></asp:TextBox>
                <asp:Label ID="LblPassError" runat="server" Text="Please Enter Password" Visible="False"></asp:Label>
            </div>
            <div>
                <asp:Label ID="LblLoginError" runat="server" Text="" Visible="False"></asp:Label>
            </div>
            <asp:Button ID="BtnSubmit" runat="server" Text="Login" CssClass="SubmitBtn" OnClick="BtnSubmit_Click" Enabled="false"/>
            <script>
                document.getElementById('BtnSubmit').removeAttribute("disabled");
            </script>
            <div>
                <span style="color:red;">
                    <noscript>
                        This Web Application uses Java Script, Please enable Java Script to continue.
                    </noscript>
                </span>
            </div>
            
        </div>
    </main>
    </div>
    </form>
</body>
</html>
