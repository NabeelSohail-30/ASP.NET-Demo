<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C11Buttons.aspx.cs" Inherits="CsharpWebAppDemo.C11Buttons" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Buttons(Post)</h1>
        Enter Name
        <asp:TextBox ID="TextBox1" runat="server" onblur="alert('text focus lost');"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" OnClientClick="alert('Clicked');"/>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton(Submit)</asp:LinkButton>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="60px" ImageUrl="~/Images/CSharp.png" OnClick="ImageButton1_Click" OnClientClick="return IsFormPosted();" />
        <br />
        <br />
    </div>
    </form>
</body>
    <script>
        function IsFormPosted() {
            return confirm('Do you want to submit (Y/n)?');
        }
    </script>
</html>
