<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm11.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="LoginId" DataSourceID="SqlDataSource1" ShowFooter="True">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:TemplateField HeaderText="LoginId" InsertVisible="False" SortExpression="LoginId">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("LoginId") %>'></asp:Label>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:LinkButton ID="btnSave" runat="server" OnClick="btnSave_Click">Save</asp:LinkButton>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("LoginId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="LoginEmail" SortExpression="LoginEmail">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("LoginEmail") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("LoginEmail") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UserFullName" SortExpression="UserFullName">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("UserFullName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("UserFullName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="LoginPassword" SortExpression="LoginPassword">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("LoginPassword") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("LoginPassword") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UserRoleId" SortExpression="UserRoleId">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("UserRoleId") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtRoleId" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("UserRoleId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="IsActive" SortExpression="IsActive">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("IsActive") %>' />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:CheckBox ID="ckActive" runat="server" />
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("IsActive") %>' Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoLMSConnectionString %>" DeleteCommand="DELETE FROM [LoginUsersDetail] WHERE [LoginId] = @LoginId" InsertCommand="INSERT INTO [LoginUsersDetail] ([LoginEmail], [UserFullName], [LoginPassword], [UserRoleId], [IsActive]) VALUES (@LoginEmail, @UserFullName, @LoginPassword, @UserRoleId, @IsActive)" SelectCommand="SELECT [LoginId], [LoginEmail], [UserFullName], [LoginPassword], [UserRoleId], [IsActive] FROM [LoginUsersDetail]" UpdateCommand="UPDATE [LoginUsersDetail] SET [LoginEmail] = @LoginEmail, [UserFullName] = @UserFullName, [LoginPassword] = @LoginPassword, [UserRoleId] = @UserRoleId, [IsActive] = @IsActive WHERE [LoginId] = @LoginId">
            <DeleteParameters>
                <asp:Parameter Name="LoginId" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="LoginEmail" Type="String" />
                <asp:Parameter Name="UserFullName" Type="String" />
                <asp:Parameter Name="LoginPassword" Type="String" />
                <asp:Parameter Name="UserRoleId" Type="Int16" />
                <asp:Parameter Name="IsActive" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="LoginEmail" Type="String" />
                <asp:Parameter Name="UserFullName" Type="String" />
                <asp:Parameter Name="LoginPassword" Type="String" />
                <asp:Parameter Name="UserRoleId" Type="Int16" />
                <asp:Parameter Name="IsActive" Type="Boolean" />
                <asp:Parameter Name="LoginId" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
