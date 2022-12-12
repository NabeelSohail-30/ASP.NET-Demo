<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginInsert.aspx.cs" Inherits="CsharpWebAppDemo.Database.StoredProcedureDemo.LoginInsert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Add Login</h1>


    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="RoleId (1-3)"></asp:Label>
        <asp:TextBox ID="TxtRole" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="IsActive"></asp:Label>
        <asp:TextBox ID="TxtIsActive" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        <br />
        <br />
        <asp:Label ID="lblRowsAff" runat="server"></asp:Label>
    </form>
</body>
</html>
