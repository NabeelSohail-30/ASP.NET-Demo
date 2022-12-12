<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C29_ValSummary.aspx.cs" Inherits="CsharpWebAppDemo.C29_ValSummary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label3" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name cannot be NULL" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age must be between 18 to 40" ControlToValidate="TextBox1" ForeColor="Red" MaximumValue="40" MinimumValue="18" Type="Integer" Display="Dynamic">*</asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Cannot be NULL" ForeColor="#3333CC">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Date"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="Date must be between 01-01-2000 to 31-12-2030" ForeColor="Red" ControlToValidate="TextBox2" MaximumValue="31-12-2030" MinimumValue="01-01-2000" Type="Date">*</asp:RangeValidator>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF6600" HeaderText="Page Error" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
