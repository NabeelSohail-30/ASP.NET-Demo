<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Using DataSource Controls - SqlDataSource</h1>

        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="AuthorName" DataValueField="AuthorId">
        </asp:DropDownList>
        <br />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BookId" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="BookName" HeaderText="BookName" SortExpression="BookName" />
                <asp:BoundField DataField="BookId" HeaderText="BookId" ReadOnly="True" SortExpression="BookId" />
                <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                <asp:BoundField DataField="Language" HeaderText="Language" SortExpression="Language" />
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
                <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher" />
                <asp:BoundField DataField="BookPages" HeaderText="BookPages" SortExpression="BookPages" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:BoundField DataField="Cabinet" HeaderText="Cabinet" SortExpression="Cabinet" />
                <asp:BoundField DataField="Shelve" HeaderText="Shelve" SortExpression="Shelve" />
            </Columns>
        </asp:GridView>
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoLMSConnectionString %>" SelectCommand="SELECT [BookName], [BookId], [Category], [Language], [AuthorName], [Publisher], [BookPages], [Quantity], [Cabinet], [Shelve] FROM [View_BooksDetailView]"></asp:SqlDataSource>

        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DemoLMSConnectionString %>" SelectCommand="SELECT * FROM [ListAuthor]"></asp:SqlDataSource>
    </form>
</body>
</html>
