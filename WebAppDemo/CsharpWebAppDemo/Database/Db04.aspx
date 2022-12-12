<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Db04.aspx.cs" Inherits="CsharpWebAppDemo.Database.Db04" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Fill Drop Down using OOP Approach</h1>
        <asp:DropDownList ID="ListAuthor" runat="server"></asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:DropDownList ID="ListCategory" runat="server"></asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
