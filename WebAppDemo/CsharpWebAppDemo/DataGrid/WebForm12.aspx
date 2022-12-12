<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm12.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" ShowFooter="True">
            <Columns>
                <asp:TemplateField HeaderText="AuthorId" SortExpression="AuthorId">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("AuthorId") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Save</asp:LinkButton>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("AuthorId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="AuthorName" SortExpression="AuthorName">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("AuthorName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("AuthorName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gender" SortExpression="Gender">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Gender") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="ddGender" runat="server" Height="16px" Width="135px">
                            <asp:ListItem>Select Gender</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Active" SortExpression="Active">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Active") %>' />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:CheckBox ID="checkActive" runat="server" />
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Active") %>' Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" InsertMethod="AddAuthor" SelectMethod="GetAllAuthors" TypeName="CsharpWebAppDemo.Database.Models.Author">
            <InsertParameters>
                <asp:Parameter Name="AuthorName" Type="String" />
                <asp:Parameter Name="Gender" Type="String" />
                <asp:Parameter Name="Active" Type="Boolean" />
            </InsertParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
