<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C24_ValidationControl.aspx.cs" Inherits="CsharpWebAppDemo.C24_ValidationControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>RequiredField Validator</h1>

    </div>
    &nbsp;<asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name cannot be NULL" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Gender:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="42px" Width="126px" Font-Size="Medium">
            <asp:ListItem Value="-1">Select Gender</asp:ListItem>
            <asp:ListItem Value="1">Male</asp:ListItem>
            <asp:ListItem Value="2">Female</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Gender must be Selected" ForeColor="Red" InitialValue="-1"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" Width="60px" />
    </form>
</body>
</html>
