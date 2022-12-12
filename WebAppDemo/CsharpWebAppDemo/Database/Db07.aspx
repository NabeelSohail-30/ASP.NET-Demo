<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Db07.aspx.cs" Inherits="CsharpWebAppDemo.Database.Db07" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Data Binding</h1>
        <h2>Data Binding with drop down</h2>
        <asp:DropDownList ID="ListAuthor" runat="server"></asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TxtAuthorId" runat="server"></asp:TextBox>
        <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
        <br />
        <asp:TextBox ID="TxtAuthorName" runat="server" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="244px">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
