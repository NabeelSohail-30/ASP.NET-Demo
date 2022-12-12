<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm21.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm21" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="LoginId" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="LoginId" HeaderText="LoginId" InsertVisible="False" ReadOnly="True" SortExpression="LoginId" />
                <asp:BoundField DataField="LoginEmail" HeaderText="LoginEmail" SortExpression="LoginEmail" />
                <asp:BoundField DataField="UserFullName" HeaderText="UserFullName" SortExpression="UserFullName" />
                <asp:CheckBoxField DataField="IsActive" HeaderText="IsActive" SortExpression="IsActive" />
            </Columns>
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoLMSConnectionString %>" SelectCommand="SELECT [LoginEmail], [UserFullName], [IsActive], [LoginId] FROM [LoginUsersDetail]"></asp:SqlDataSource>
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="LoginId" DataSourceID="SqlDataSource2" Height="50px" Width="125px" OnItemDeleted="DetailsView1_ItemDeleted" OnItemInserted="DetailsView1_ItemInserted" OnItemUpdated="DetailsView1_ItemUpdated">
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="LoginId" HeaderText="LoginId" InsertVisible="False" ReadOnly="True" SortExpression="LoginId" />
                <asp:BoundField DataField="LoginEmail" HeaderText="LoginEmail" SortExpression="LoginEmail" />
                <asp:BoundField DataField="UserFullName" HeaderText="UserFullName" SortExpression="UserFullName" />
                <asp:BoundField DataField="LoginPassword" HeaderText="LoginPassword" SortExpression="LoginPassword" />
                <asp:BoundField DataField="UserRoleId" HeaderText="UserRoleId" SortExpression="UserRoleId" />
                <asp:CheckBoxField DataField="IsActive" HeaderText="IsActive" SortExpression="IsActive" />
                <asp:BoundField DataField="LoggedDateTime" HeaderText="LoggedDateTime" SortExpression="LoggedDateTime" />
                <asp:BoundField DataField="FailedAttempt" HeaderText="FailedAttempt" SortExpression="FailedAttempt" />
                <asp:CheckBoxField DataField="AccountLocked" HeaderText="AccountLocked" SortExpression="AccountLocked" />
                <asp:BoundField DataField="UserCreatedById" HeaderText="UserCreatedById" SortExpression="UserCreatedById" />
                <asp:BoundField DataField="CreationDateTime" HeaderText="CreationDateTime" SortExpression="CreationDateTime" />
                <asp:BoundField DataField="UserLastUpdatedById" HeaderText="UserLastUpdatedById" SortExpression="UserLastUpdatedById" />
                <asp:BoundField DataField="LastUpdatedDateTime" HeaderText="LastUpdatedDateTime" SortExpression="LastUpdatedDateTime" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DemoLMSConnectionString %>" SelectCommand="SELECT * FROM [LoginUsersDetail] WHERE ([LoginId] = @LoginId)" DeleteCommand="DELETE FROM [LoginUsersDetail] WHERE [LoginId] = @LoginId" InsertCommand="INSERT INTO [LoginUsersDetail] ([LoginEmail], [UserFullName], [LoginPassword], [UserRoleId], [IsActive], [LoggedDateTime], [FailedAttempt], [AccountLocked], [UserCreatedById], [CreationDateTime], [UserLastUpdatedById], [LastUpdatedDateTime]) VALUES (@LoginEmail, @UserFullName, @LoginPassword, @UserRoleId, @IsActive, @LoggedDateTime, @FailedAttempt, @AccountLocked, @UserCreatedById, @CreationDateTime, @UserLastUpdatedById, @LastUpdatedDateTime)" UpdateCommand="UPDATE [LoginUsersDetail] SET [LoginEmail] = @LoginEmail, [UserFullName] = @UserFullName, [LoginPassword] = @LoginPassword, [UserRoleId] = @UserRoleId, [IsActive] = @IsActive, [LoggedDateTime] = @LoggedDateTime, [FailedAttempt] = @FailedAttempt, [AccountLocked] = @AccountLocked, [UserCreatedById] = @UserCreatedById, [CreationDateTime] = @CreationDateTime, [UserLastUpdatedById] = @UserLastUpdatedById, [LastUpdatedDateTime] = @LastUpdatedDateTime WHERE [LoginId] = @LoginId">
            <DeleteParameters>
                <asp:Parameter Name="LoginId" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="LoginEmail" Type="String" />
                <asp:Parameter Name="UserFullName" Type="String" />
                <asp:Parameter Name="LoginPassword" Type="String" />
                <asp:Parameter Name="UserRoleId" Type="Int16" />
                <asp:Parameter Name="IsActive" Type="Boolean" />
                <asp:Parameter Name="LoggedDateTime" Type="DateTime" />
                <asp:Parameter Name="FailedAttempt" Type="Int16" />
                <asp:Parameter Name="AccountLocked" Type="Boolean" />
                <asp:Parameter Name="UserCreatedById" Type="Int32" />
                <asp:Parameter DbType="Date" Name="CreationDateTime" />
                <asp:Parameter Name="UserLastUpdatedById" Type="Int32" />
                <asp:Parameter DbType="Date" Name="LastUpdatedDateTime" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="LoginId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="LoginEmail" Type="String" />
                <asp:Parameter Name="UserFullName" Type="String" />
                <asp:Parameter Name="LoginPassword" Type="String" />
                <asp:Parameter Name="UserRoleId" Type="Int16" />
                <asp:Parameter Name="IsActive" Type="Boolean" />
                <asp:Parameter Name="LoggedDateTime" Type="DateTime" />
                <asp:Parameter Name="FailedAttempt" Type="Int16" />
                <asp:Parameter Name="AccountLocked" Type="Boolean" />
                <asp:Parameter Name="UserCreatedById" Type="Int32" />
                <asp:Parameter DbType="Date" Name="CreationDateTime" />
                <asp:Parameter Name="UserLastUpdatedById" Type="Int32" />
                <asp:Parameter DbType="Date" Name="LastUpdatedDateTime" />
                <asp:Parameter Name="LoginId" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource2" DataKeyNames="AuthorId">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" SortExpression="AuthorId" />
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:CheckBoxField DataField="Active" HeaderText="Active" SortExpression="Active" />
                <asp:BoundField DataField="ImageURL" HeaderText="ImageURL" SortExpression="ImageURL" />
                <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" SortExpression="TotalPrice" />
                <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
            </Columns>
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
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllAuthors" TypeName="CsharpWebAppDemo.Database.Models.Author"></asp:ObjectDataSource>
        <br />
        <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" Height="50px" Width="125px" OnItemDeleted="DetailsView2_ItemDeleted" OnItemInserted="DetailsView2_ItemInserted" OnItemUpdated="DetailsView2_ItemUpdated" DataKeyNames="AuthorId">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <EditRowStyle BackColor="#2461BF" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" SortExpression="AuthorId" />
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:CheckBoxField DataField="Active" HeaderText="Active" SortExpression="Active" />
                <asp:BoundField DataField="ImageURL" HeaderText="ImageURL" SortExpression="ImageURL" />
                <asp:BoundField DataField="TotalPrice" HeaderText="TotalPrice" SortExpression="TotalPrice" />
                <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="FindById" TypeName="CsharpWebAppDemo.Database.Models.Author" DeleteMethod="DeleteById" InsertMethod="AddAuthor" UpdateMethod="UpdateAuthor">
            <DeleteParameters>
                <asp:Parameter Name="AuthorId" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="AuthorName" Type="String" />
                <asp:Parameter Name="Gender" Type="String" />
                <asp:Parameter Name="Active" Type="Boolean" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView2" Name="id" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="authorId" Type="Int32" />
                <asp:Parameter Name="authorName" Type="String" />
                <asp:Parameter Name="Gender" Type="String" />
                <asp:Parameter Name="Active" Type="Boolean" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <br />
        <br />
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="AuthorId" OnRowCommand="GridView3_RowCommand">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="SelectRow">Select</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" SortExpression="AuthorId" />
                <asp:BoundField DataField="AuthorName" HeaderText="AuthorName" SortExpression="AuthorName" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:DetailsView ID="DetailsView3" runat="server" Height="50px" Width="125px" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" AutoGenerateInsertButton="True" OnItemInserting="DetailsView3_ItemInserting" OnItemUpdating="DetailsView3_ItemUpdating" OnModeChanging="DetailsView3_ModeChanging">
        </asp:DetailsView>
        <br />
    </form>
</body>
</html>
