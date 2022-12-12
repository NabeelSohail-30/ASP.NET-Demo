<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C20_HiddenField.aspx.cs" Inherits="CsharpWebAppDemo.C20_HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
        <asp:TextBox ID="TxtFindId" runat="server"></asp:TextBox>
        <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
        <p>
            <asp:HiddenField ID="HiddenId" runat="server" />
        </p>
        <asp:TextBox ID="TxtId" runat="server" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="TxtRole" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
    </form>
</body>
    <script>
        alert(document.getElementById('HiddenId').value);
    </script>
</html>
