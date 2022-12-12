<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C04TextBox.aspx.cs" Inherits="CsharpWebAppDemo.C04TextBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .smallsize{
            border : 2px solid orange;

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Text Box Control</h1>
    </div>
        UserName:
        <asp:TextBox ID="TextBox1" runat="server" BackColor="#FFFF66" Columns="15" Enabled="False" MaxLength="10" CssClass="smallsize" TabIndex="1" Visible="False"></asp:TextBox>
        <br />
        Password:
        <asp:TextBox ID="TxtPass" runat="server" TextMode="Password" BorderStyle="Dotted" BorderColor="Red" BorderWidth="3" AutoPostBack="True" OnTextChanged="TxtPass_TextChanged" TabIndex="2"></asp:TextBox>
        <br />
        Address:
        <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Rows="3" TabIndex="3" ToolTip="Enter Your Address"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show User Name" Width="186px" />
        <br />
        <br />
    </form>
</body>
</html>
