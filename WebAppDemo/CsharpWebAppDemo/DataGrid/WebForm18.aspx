<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm18.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm18" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowSorting="true"
            OnSorting="GridView1_Sorting"
            currentSortField="AuthorId" currentSortDirection="ASC" OnRowCreated="GridView1_RowCreated">
            <Columns>
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" SortExpression="AuthorId" />
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Active" HeaderText="Active" SortExpression="Active" />
                <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" SortExpression="TotalPrice" />
                <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
                <asp:ImageField DataImageUrlField="ImageURL" HeaderText="Image" NullImageUrl="~/Images/Author/p1.png" SortExpression="ImageURL">
                </asp:ImageField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
