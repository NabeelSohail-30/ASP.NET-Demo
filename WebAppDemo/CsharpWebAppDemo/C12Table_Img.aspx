<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C12Table_Img.aspx.cs" Inherits="CsharpWebAppDemo.C12Table_Img" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Image</h1>
        <a href="Images/CSharp.png">
        <asp:Image ID="Image1" runat="server" BackColor="#CCFFCC" Height="116px" ImageUrl="~/Images/CSharp.png" Width="113px" /></a>
        <br />
        <br />
        <br />
        <br />
        <h1>Table</h1>
        <asp:Table ID="Table1" runat="server" BorderColor="#FF3399" BorderStyle="Dashed" BorderWidth="3px" Width="441px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">R1 C1</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">R2 C1</asp:TableCell>
                <asp:TableCell runat="server">R2C2</asp:TableCell>
                <asp:TableCell runat="server">R2C3</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
        <br />
        <h1>Dynamic Table</h1>
        <asp:Table ID="Table2" runat="server"></asp:Table>
        <br />
        <br />

        <table>
            <tbody>
                <% 
                    for (int i = 1; i < 4; i++)
                    {
                %>
                <tr>
                    <td>Name</td>
                </tr>
                <%
                    }
                %>
            </tbody>
        </table>

        <br />
    </div>
    </form>
</body>
</html>
