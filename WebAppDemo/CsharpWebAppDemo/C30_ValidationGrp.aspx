<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C30_ValidationGrp.aspx.cs" Inherits="CsharpWebAppDemo.C30_ValidationGrp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" BorderStyle="Double">
            <h1>Login</h1>
            UserName: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Cannot be Null" ValidationGroup="login"></asp:RequiredFieldValidator>
            <br />
            Password: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Cannot be Null" ValidationGroup="login"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" ValidationGroup="login" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="login" />
        </asp:Panel>

        <asp:Panel ID="Panel2" runat="server" BorderStyle="Double">
            <h1>Registration</h1>
            UserName: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Cannot be NULL" ValidationGroup="reg"></asp:RequiredFieldValidator>
            <br />
            Password: <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="NULL" ValidationGroup="reg"></asp:RequiredFieldValidator>
            <br />
            Confirm Password: <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="NULL" ValidationGroup="reg"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="NOT Matched" ValidationGroup="reg"></asp:CompareValidator>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" ValidationGroup="reg" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary2" runat="server" ValidationGroup="reg" />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
