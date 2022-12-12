<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Db08_Disconnected.aspx.cs" Inherits="CsharpWebAppDemo.Database.Db08_Disconnected" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Using Sql DataReader and DataTable</h1>
        <p>&nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="198px">
            </asp:DropDownList>
        </p>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
