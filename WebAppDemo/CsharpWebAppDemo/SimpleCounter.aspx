<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleCounter.aspx.cs" Inherits="CsharpWebAppDemo.SimpleCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Counter App</title>
</head>

<body>
    
        <h1>Counter</h1>
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="Label2" runat="server" Text="Counter Value : "></asp:Label>
                <asp:Label ID="LblValue" runat="server" Text="0"></asp:Label>
                <br />
                <asp:Button ID="BtnReset" runat="server" Text="Reset Counter" OnClick="ButtonResetCounter" />
                <br />
                <asp:Button ID="BtnCounter" runat="server" Text="Counter" OnClick="ButtonCounter" Width="126px" />
            </div>
    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </form>
   
</body>

</html>