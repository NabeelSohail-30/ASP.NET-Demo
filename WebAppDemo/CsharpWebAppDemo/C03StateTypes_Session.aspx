<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C03StateTypes_Session.aspx.cs" Inherits="CsharpWebAppDemo.C03StateTypes_Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Retreive Stored Value from Session Object</h1>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="LblName" runat="server" Text="Enter Name"></asp:Label>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        </div>
    </div>
        <h1>Retrieve from view state</h1>
        <div>
            <asp:Label ID="Label1" runat="server" Text="My Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
