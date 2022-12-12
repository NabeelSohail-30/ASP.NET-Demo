<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C15_BulletedList.aspx.cs" Inherits="CsharpWebAppDemo.C15_BulletedList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Bulleted List<br />
        <br />
        <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="Disc" DisplayMode="LinkButton" OnClick="BulletedList1_Click">
            <asp:ListItem Value="1">Youtube</asp:ListItem>
            <asp:ListItem Value="2">Turkey</asp:ListItem>
            <asp:ListItem Value="3">Germany</asp:ListItem>
            <asp:ListItem Value="4">UK</asp:ListItem>
            <asp:ListItem Value="5">Kuwait</asp:ListItem>
            
        </asp:BulletedList>
    
    </div>
    </form>
</body>
</html>
