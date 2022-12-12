<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C09DropDownRunTimeVal.aspx.cs" Inherits="CsharpWebAppDemo.C09DropDownRunTimeVal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Add Drop Down Items on run time</h1>
        <asp:DropDownList ID="DropDownList1" runat="server" Width="142px"></asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Height="27px" OnClick="Button1_Click" Text="Button" Width="116px" />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="139px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="140px">
        </asp:DropDownList>
        <br />
    </div>
    </form>
</body>
</html>
