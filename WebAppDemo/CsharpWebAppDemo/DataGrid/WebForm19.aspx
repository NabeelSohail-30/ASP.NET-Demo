<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm19.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm19" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        SQL Data Source<br />
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="AuthorId" DataSourceID="SqlDataSource1" GridLines="Horizontal" PageSize="8">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" InsertVisible="False" ReadOnly="True" SortExpression="AuthorId" />
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:CheckBoxField DataField="Active" HeaderText="Active" SortExpression="Active" />
                <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" SortExpression="TotalPrice" />
                <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
                <asp:BoundField DataField="ImageURL" HeaderText="ImageURL" SortExpression="ImageURL" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerSettings Mode="NextPreviousFirstLast" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoLMSConnectionString %>" SelectCommand="SELECT * FROM [ListAuthor]"></asp:SqlDataSource>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            Object Data Source</p>
        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnPreRender="GridView2_PreRender" PageSize="4">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" SortExpression="AuthorId" />
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:CheckBoxField DataField="Active" HeaderText="Active" SortExpression="Active" />
                <asp:BoundField DataField="ImageURL" HeaderText="ImageURL" SortExpression="ImageURL" />
                <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" SortExpression="TotalPrice" />
                <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllAuthors" TypeName="CsharpWebAppDemo.Database.Models.Author"></asp:ObjectDataSource>
        <br />
        Without Data Source
        <asp:GridView ID="GridView3" runat="server" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" AllowPaging="true" PageSize="4" OnPageIndexChanging="GridView3_PageIndexChanging">
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
        <br />
        <br />
        Custom Paging using ObjectDataSource<br />
        <asp:GridView ID="GridView4" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource2" ForeColor="#333333" GridLines="None" OnPreRender="GridView2_PreRender" PageSize="4">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" SortExpression="AuthorId" />
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:CheckBoxField DataField="Active" HeaderText="Active" SortExpression="Active" />
                <asp:BoundField DataField="ImageURL" HeaderText="ImageURL" SortExpression="ImageURL" />
                <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" SortExpression="TotalPrice" />
                <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllAuthorsPageWise" TypeName="CsharpWebAppDemo.Database.Models.Author" StartRowIndexParameterName="StartIndex" MaximumRowsParameterName="MaximumRows" SelectCountMethod="Count" EnablePaging="true">
        </asp:ObjectDataSource>
        <br />
        <br />
        Custom Paging without Data Source<br />
        <asp:GridView ID="GridView5" runat="server" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" PageSize="4" AllowPaging="true">
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
        <br />
        <asp:Repeater ID="repeaterPaging" runat="server">
            <ItemTemplate>
                <asp:LinkButton ID="pagingLinkButton" runat="server" Text='<%#Eval("Text") %>' CommandArgument='<%#Eval("Value") %>' Enabled='<%#Eval("Enabled") %>' OnClick="pagingLinkButton_Click">LinkButton</asp:LinkButton>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
