<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Sql Data Source using Stored Procedure</h1>


    </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="sqlAuthor" DataTextField="AuthorName" DataValueField="AuthorId" Height="50px" Width="200px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="BookId" DataSourceID="SqlDataSource1" OnPreRender="GridView1_PreRender" OnRowDataBound="GridView1_RowDataBound">
            <Columns>
                <asp:BoundField DataField="BookId" HeaderText="BookId" InsertVisible="False" ReadOnly="True" SortExpression="BookId" />
                <asp:BoundField DataField="BookName" HeaderText="BookName" SortExpression="BookName" />
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" SortExpression="AuthorId" />
                <asp:BoundField DataField="LanguageId" HeaderText="LanguageId" SortExpression="LanguageId" />
                <asp:BoundField DataField="BookPages" HeaderText="BookPages" SortExpression="BookPages" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <asp:SqlDataSource ID="sqlAuthor" runat="server" ConnectionString="<%$ ConnectionStrings:DemoLMSConnectionString %>" SelectCommand="spGetAuthors" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoLMSConnectionString %>" SelectCommand="spGetBooksByAuthor" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="pAuthorID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
