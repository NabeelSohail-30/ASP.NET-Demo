<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm14.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm14" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="AuthorId" DataSourceID="SqlDataSource1" OnRowDataBound="GridView1_RowDataBound" ShowFooter="True" EmptyDataText="Data Not Found" AllowSorting="True">
            <EmptyDataTemplate>
                <table>
                    <thead>
                        <tr>
                            <td>Author Id</td>
                            <td>Author Name</td>
                            <td>Gender</td>
                            <td>Active</td>
                            <td>Price</td>
                            <td>Qty</td>
                        </tr>
                    </thead>

                    <tbody>
                        <tr>
                            <td colspan="6"><h1>There are no record found</h1></td>
                        </tr>
                    </tbody>
                </table>
                
            </EmptyDataTemplate>
            <Columns>
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" InsertVisible="False" ReadOnly="True" SortExpression="AuthorId" />
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:CheckBoxField DataField="Active" HeaderText="Active" SortExpression="Active" />
                <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" SortExpression="TotalPrice" />
                <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
            </Columns>
            <EmptyDataRowStyle BackColor="#0099FF" ForeColor="#660033" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoLMSConnectionString %>" SelectCommand="SELECT * FROM [ListAuthor]"></asp:SqlDataSource>
    </form>
</body>
</html>
