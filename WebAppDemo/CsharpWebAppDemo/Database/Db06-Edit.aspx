<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Db06-Edit.aspx.cs" Inherits="CsharpWebAppDemo.Database.Db06_Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ListAuthor" runat="server"></asp:DropDownList>
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Author Name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
    </div>
    </form>
</body>
</html>
