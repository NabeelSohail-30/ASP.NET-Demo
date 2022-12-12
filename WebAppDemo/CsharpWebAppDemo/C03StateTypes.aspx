<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C03StateTypes.aspx.cs" Inherits="CsharpWebAppDemo.C03StateTypes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h2>How to store Posted values so can be accessed in different Pages.</h2>
    <p>1. Session State - Stores for a Single Browser Session</p>
    <p>2. Applicaton State - Stores for a Entire Application State.</p>
    <p>3. View State - Stores for a Single Page for Single Session.</p>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label ID="LblName" runat="server" Text="Enter Name"></asp:Label>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="Button1" runat="server" Text="Session State" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View State" Width="124px" />
        </div>
    </div>
        <asp:TextBox ID="TextBox1" runat="server" Height="36px" Width="236px"></asp:TextBox>
    </form>
</body>
</html>
