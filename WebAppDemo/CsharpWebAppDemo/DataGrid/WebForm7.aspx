<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Delete row from Grid using SqlDataSource</h1>


    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="AuthorId" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" OnRowDataBound="GridView1_RowDataBound" OnRowDeleted="GridView1_RowDeleted">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" InsertVisible="False" ReadOnly="True" SortExpression="AuthorId" />
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="Gray" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoLMSConnectionString %>" DeleteCommand="DELETE FROM [ListAuthor] WHERE [AuthorId] = @original_AuthorId AND (([AuthorName] = @original_AuthorName) OR ([AuthorName] IS NULL AND @original_AuthorName IS NULL))" SelectCommand="SELECT * FROM [ListAuthor]" ConflictDetection="CompareAllValues" OldValuesParameterFormatString="original_{0}">
            <DeleteParameters>
                <asp:Parameter Name="original_AuthorId" Type="Int32" />
                <asp:Parameter Name="original_AuthorName" Type="String" />
            </DeleteParameters>
            
            
        </asp:SqlDataSource>
    </form>
</body>
</html>
