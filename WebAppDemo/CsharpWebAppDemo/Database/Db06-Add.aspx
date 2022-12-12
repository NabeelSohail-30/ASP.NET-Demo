<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Db06-Add.aspx.cs" Inherits="CsharpWebAppDemo.Database.Db06_Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ListAuthor" runat="server"></asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Author Name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
