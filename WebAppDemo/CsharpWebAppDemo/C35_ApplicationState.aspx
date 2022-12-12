<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C35_ApplicationState.aspx.cs" Inherits="CsharpWebAppDemo.C35_ApplicationState" %>

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
            <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click"/>
            <br />
            <asp:Label ID="onlineusers" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
