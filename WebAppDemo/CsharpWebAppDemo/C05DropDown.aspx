<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C05DropDown.aspx.cs" Inherits="CsharpWebAppDemo.C05DropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Drop Down Box</h1>
        <asp:DropDownList ID="ListCountry" runat="server" BackColor="#0033CC" Font-Bold="True" ForeColor="#FFFFCC" Height="38px" Width="157px">
            <asp:ListItem Selected="True" Value="-1">Select Country</asp:ListItem>
            <asp:ListItem Value="1">Pakistan</asp:ListItem>
            <asp:ListItem Value="2">India</asp:ListItem>
            <asp:ListItem Value="3">Kuwait</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="132px" />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
