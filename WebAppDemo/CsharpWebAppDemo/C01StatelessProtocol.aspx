<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C01StatelessProtocol.aspx.cs" Inherits="CsharpWebAppDemo.C01StatelessProtocol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Stateless vs Non Stateless</h1>
    <form id="form1" runat="server">
    <div>
        <div>
            <label>Enter First Name</label>
            <br />
            <input id="TxtName" type="text" />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>

        <div>
            <label>Enter Father Name</label>
            <br />
            <input id="TxtFather" type="text" />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>

        <div>
            <!--<input id="Submit1" type="submit" value="submit" />-->
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </div>
    </form>
</body>
</html>
