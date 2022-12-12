<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C06CheckBox.aspx.cs" Inherits="CsharpWebAppDemo.C06CheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Check Box</h1>
        <asp:Label ID="Label1" runat="server" Text="CheckBox01"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="CheckBox02"></asp:Label>
        <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="CheckBox03"></asp:Label>
        <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox3_CheckedChanged" />
        <br />
        <br />
        Check Box List<br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="1">Master</asp:ListItem>
            <asp:ListItem Value="2">Bachelor</asp:ListItem>
            <asp:ListItem Value="3">PHD</asp:ListItem>
            <asp:ListItem Value="4">Intermediate</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="152px" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
