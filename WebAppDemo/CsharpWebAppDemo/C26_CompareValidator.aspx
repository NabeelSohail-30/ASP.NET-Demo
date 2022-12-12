<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C26_CompareValidator.aspx.cs" Inherits="CsharpWebAppDemo.C26_CompareValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Compare Validator</h1>

        <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <%--<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator"></asp:CompareValidator>--%>
        <br />

        <asp:Label ID="Label2" runat="server" Text="Re-Password"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Password not Matched" ControlToCompare="TextBox2" ControlToValidate="TextBox1" ForeColor="Red"></asp:CompareValidator>
        <br />

        <asp:Label ID="Label3" runat="server" Text="Date of Application"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator3" runat="server" ErrorMessage="Invalid Date" ControlToValidate="TextBox3" ForeColor="Red" Operator="GreaterThanEqual" Type="Date" ValueToCompare="01-01-2022"></asp:CompareValidator>
        <br />

        <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator4" runat="server" ErrorMessage="Not an Int" ControlToValidate="TextBox4" ForeColor="Red" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
        <br />

        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
