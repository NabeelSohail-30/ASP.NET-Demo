<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C32_QueryStr.aspx.cs" Inherits="CsharpWebAppDemo.C32_QueryStr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Save" Height="29px" OnClick="Button1_Click" Width="62px"/>
            <br />
        </div>
    </form>
</body>
</html>
