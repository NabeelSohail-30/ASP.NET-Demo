<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm15.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm15" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        <asp:CheckBox ID="ckSelectAll" runat="server" AutoPostBack="True" OnCheckedChanged="ckSelectAll_CheckedChanged" />
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="ckSelect" runat="server" AutoPostBack="True" OnCheckedChanged="ckSelect_CheckedChanged" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="AuthorId" SortExpression="AuthorId">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("AuthorId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:CheckBoxField DataField="Active" HeaderText="Active" SortExpression="Active" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllAuthors" TypeName="CsharpWebAppDemo.Database.Models.Author"></asp:ObjectDataSource>
    </form>
</body>
</html>
