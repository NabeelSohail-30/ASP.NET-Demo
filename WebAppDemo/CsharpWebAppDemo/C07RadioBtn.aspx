<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C07RadioBtn.aspx.cs" Inherits="CsharpWebAppDemo.C07RadioBtn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Radio Button</h1>
        Male<asp:RadioButton ID="RadioButton1" runat="server" GroupName="Gender" AutoPostBack="True" OnCheckedChanged="RadioButton1_CheckedChanged" />
        <br />
        Female<asp:RadioButton ID="RadioButton2" runat="server" GroupName="Gender" />
        <br />
        Others<asp:RadioButton ID="RadioButton3" runat="server" GroupName="Gender" />
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="92px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>Others</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
