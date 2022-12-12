<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C23_Dynamic Control.aspx.cs" Inherits="CsharpWebAppDemo.C23_Dynamic_Control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="No. Of TxtBox: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Generate" OnClick="Button1_Click" />

        <asp:Panel ID="Panel1" runat="server">
           
        </asp:Panel>


        <asp:Button ID="Button2" runat="server" Text="Get TxtBox Values" OnClick="Button2_Click" />

        <table>
            <tr>
               <td id="td1" runat="server"></td>
               <td id="td2" runat="server"></td>
               <td id="td3" runat="server"></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
