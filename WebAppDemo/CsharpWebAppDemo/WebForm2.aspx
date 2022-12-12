<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="CsharpWebAppDemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LblName" Text="Enter Name" runat="server"></asp:Label>
        <asp:TextBox ID="TxtName" runat="server" OnTextChanged="TxtName_TextChanged">Name</asp:TextBox>
    </div>

    <div>
        <asp:Label ID="LblFather" Text="Enter Father Name" runat="server"></asp:Label>
        <asp:TextBox ID="TxtFather" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Button ID="Btn01" runat="server" Text="Submit" OnClick="MyButtonClickEvent" OnInit="Btn01_Init" OnLoad="Btn01_Load" OnPreRender="Btn01_PreRender" />
    </div>
    </form>
</body>
</html>
