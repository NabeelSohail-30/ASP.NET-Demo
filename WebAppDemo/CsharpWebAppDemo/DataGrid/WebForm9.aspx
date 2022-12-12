<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Edit/Update Row using SQLDataSource</h1>

    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="LoginId" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="LoginId" HeaderText="LoginId" InsertVisible="False" ReadOnly="True" SortExpression="LoginId" />
                <asp:BoundField DataField="LoginEmail" HeaderText="LoginEmail" SortExpression="LoginEmail"/>
                <asp:BoundField DataField="UserFullName" HeaderText="UserFullName" SortExpression="UserFullName" ConvertEmptyStringToNull="false" />
                <asp:BoundField DataField="LoginPassword" HeaderText="LoginPassword" SortExpression="LoginPassword" />
                <asp:CheckBoxField DataField="IsActive" HeaderText="IsActive" SortExpression="IsActive" />
                <asp:BoundField DataField="UserRoleId" HeaderText="UserRoleId" SortExpression="UserRoleId" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoLMSConnectionString %>" DeleteCommand="DELETE FROM [LoginUsersDetail] WHERE [LoginId] = @LoginId" SelectCommand="SELECT [LoginId], [LoginEmail], [UserFullName], [LoginPassword], [IsActive], [UserRoleId] FROM [LoginUsersDetail]" UpdateCommand="UPDATE [LoginUsersDetail] SET [LoginEmail] = @LoginEmail, [UserFullName] = @UserFullName, [LoginPassword] = @LoginPassword, [IsActive] = @IsActive, [UserRoleId] = @UserRoleId WHERE [LoginId] = @LoginId">
            <DeleteParameters>
                <asp:Parameter Name="LoginId" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="LoginEmail" Type="String" />
                <asp:Parameter Name="UserFullName" Type="String" ConvertEmptyStringToNull="false" />
                <asp:Parameter Name="LoginPassword" Type="String" />
                <asp:Parameter Name="IsActive" Type="Boolean" />
                <asp:Parameter Name="UserRoleId" Type="Int16" />
                <asp:Parameter Name="LoginId" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
