<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C31_ServerTransfer.aspx.cs" Inherits="CsharpWebAppDemo.C31_ServerTransfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Web Form 01</h1>
        Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        Name: <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Goto WF 02 using redirect" OnClick="Button1_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Using Server.Transfer" OnClick="Button2_Click" />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Using Server.Execute" OnClick="Button3_Click" />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Using Cross-Page" PostBackUrl="~/C31_ServerTransfer_2.aspx"/>
        <br />
        <input id="Button1" type="button" value="html btn" onclick="window.open('C31_ServerTransfer_2.aspx');"/>
        <br />
        <asp:Button ID="Button5" runat="server" Text="Using js" OnClientClick="window.open('C31_ServerTransfer_2.aspx');"/>
        <br />
        <asp:Button ID="Button6" runat="server" Text="Using Server onClick" OnClick="Button6_Click" />
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
