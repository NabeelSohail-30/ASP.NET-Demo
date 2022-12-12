<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C08ListBox.aspx.cs" Inherits="CsharpWebAppDemo.C08ListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>List Box</h1>
        <asp:Label ID="Label1" runat="server" Text="Country"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" Rows="6">
            <asp:ListItem Selected="True" Value="-1">Select Country</asp:ListItem>
            <asp:ListItem Value="101">Pakistan</asp:ListItem>
            <asp:ListItem Value="102">Kuwait</asp:ListItem>
            <asp:ListItem Value="103">Turkey</asp:ListItem>
            <asp:ListItem Value="104">Afghanistan</asp:ListItem>
        </asp:ListBox>
        
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
    </div>
    </form>
</body>
</html>
