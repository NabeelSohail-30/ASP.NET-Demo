<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm17.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm17" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" SortExpression="AuthorId" />
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:CheckBoxField DataField="Active" HeaderText="Active" SortExpression="Active" />
                <asp:TemplateField HeaderText="ImageURL" SortExpression="ImageURL">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageURL") %>' Width="250px" Height="200px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ImageField DataImageUrlField="ImageURL" ControlStyle-Width="250px" ControlStyle-Height="200px" AlternateText="Author Image" NullImageUrl="~/Images/Author/p1.png">
<ControlStyle Height="200px" Width="250px"></ControlStyle>
                </asp:ImageField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllAuthors" TypeName="CsharpWebAppDemo.Database.Models.Author" SortParameterName="sortColumn">
        </asp:ObjectDataSource>
    </form>
</body>
</html>
