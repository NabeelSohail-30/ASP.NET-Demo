<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>ObjectDataSource</h1>

        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="BookId" HeaderText="BookId" SortExpression="BookId" />
                <asp:BoundField DataField="BookName" HeaderText="BookName" SortExpression="BookName" />
                <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" SortExpression="CategoryId" />
                <asp:BoundField DataField="LanguageId" HeaderText="LanguageId" SortExpression="LanguageId" />
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" SortExpression="AuthorId" />
                <asp:BoundField DataField="PublisherId" HeaderText="PublisherId" SortExpression="PublisherId" />
                <asp:BoundField DataField="BookPages" HeaderText="BookPages" SortExpression="BookPages" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:BoundField DataField="CabinetId" HeaderText="CabinetId" SortExpression="CabinetId" />
                <asp:BoundField DataField="ShelveId" HeaderText="ShelveId" SortExpression="ShelveId" />
            </Columns>
        </asp:GridView>
        <br />

    </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllBooks" TypeName="CsharpWebAppDemo.Database.Models.Books"></asp:ObjectDataSource>
    </form>
</body>
</html>
