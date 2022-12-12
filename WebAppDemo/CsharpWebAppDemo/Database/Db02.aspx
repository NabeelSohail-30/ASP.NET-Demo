<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Db02.aspx.cs" Inherits="CsharpWebAppDemo.Database.Db02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Insert data in Drop Down on runtime through db.</h1>
        <asp:DropDownList ID="DDAuthor" runat="server" Height="40px" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DDAuthor_SelectedIndexChanged"></asp:DropDownList>
        <br /><br /><br /><br />
        <asp:DropDownList ID="DDCategory" runat="server" Height="40px" Width="200px" AutoPostBack="True"></asp:DropDownList>
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
    </div>
    </form>
</body>
</html>
