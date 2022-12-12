<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm4" Culture="en-GB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Button ID="Button1" runat="server" Height="39px" OnClick="Button1_Click" Text="Get All Cultures" Width="158px" />
        <br />
        <br />
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeId" DataSourceID="SqlDataSource1" Height="222px" Width="960px" OnRowDataBound="GridView1_RowDataBound" CellPadding="4" ForeColor="#333333" GridLines="None" ShowFooter="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="EmployeeId" HeaderText="EmployeeId" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeId" Visible="False" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName"/>
                <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
                <asp:BoundField DataField="DateOfBirth" HeaderText="Date Of Birth" SortExpression="DateOfBirth" DataFormatString="{0:D}" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Nationality" HeaderText="Nationality" SortExpression="Nationality" />
                <asp:BoundField DataField="AnnualPay" HeaderText="Annual Pay" SortExpression="AnnualPay" />
                <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" BorderColor="#339933" Font-Bold="True" Font-Size="Large" Font-Strikeout="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoLMSConnectionString %>" SelectCommand="SELECT * FROM [EmployeeDetails] ORDER BY [Department], [AnnualPay] DESC"></asp:SqlDataSource>
    </form>
</body>
</html>
