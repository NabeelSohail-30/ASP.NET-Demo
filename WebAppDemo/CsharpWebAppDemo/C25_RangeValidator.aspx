<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C25_RangeValidator.aspx.cs" Inherits="CsharpWebAppDemo.C25_RangeValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Range Validator</h1>

        <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age must be between 18 to 40" ControlToValidate="TextBox1" ForeColor="Red" MaximumValue="40" MinimumValue="18" Type="Integer" Display="Dynamic"></asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Cannot be NULL" ForeColor="#3333CC"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Date"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="Date must be between 01-01-2000 to 31-12-2030" ForeColor="Red" ControlToValidate="TextBox2" MaximumValue="31-12-2030" MinimumValue="01-01-2000" Type="Date"></asp:RangeValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
