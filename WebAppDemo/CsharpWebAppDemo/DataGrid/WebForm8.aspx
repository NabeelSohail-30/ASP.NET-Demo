<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Delete using ObjectDataSource<br />
        <br />
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="AuthorId" OnRowDeleted="GridView1_RowDeleted">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" SortExpression="AuthorId" />
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SpGetAllAuthors" TypeName="CsharpWebAppDemo.Database.Models.Author" DeleteMethod="DeleteById" ConflictDetection="CompareAllValues" OldValuesParameterFormatString="original_{0}">
            <DeleteParameters>
                <asp:Parameter Name="original_AuthorId" Type="Int32" />
                <asp:Parameter Name="original_AuthorName" Type="String" />
            </DeleteParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
