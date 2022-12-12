<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="authorId" OnRowUpdated="GridView1_RowUpdated">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="AuthorId" HeaderText="AuthorId" SortExpression="AuthorId" ReadOnly="true" />
                <asp:TemplateField HeaderText="AuthorName" SortExpression="AuthorName">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("AuthorName") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Author Name is Required" ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("AuthorName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gender" SortExpression="Gender">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="134px" SelectedValue ='<%# Bind("Gender") %>'>
                            <asp:ListItem >Select Gender</asp:ListItem>
                            <asp:ListItem >Male</asp:ListItem>
                            <asp:ListItem >Female</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Value must be Selected" ForeColor="#FF3300" InitialValue="Select Gender">*</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Active" SortExpression="Active">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked ='<%# Bind("Active") %>'/>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBoxView" runat="server" Checked ='<%# Bind("Active") %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
    
    </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllAuthors" TypeName="CsharpWebAppDemo.Database.Models.Author" UpdateMethod="UpdateAuthor" ConflictDetection="CompareAllValues" OldValuesParameterFormatString="original_{0}" OnUpdated="ObjectDataSource1_Updated">
            <UpdateParameters>
                <asp:Parameter Name="original_authorId" Type="Int32" />
                <asp:Parameter Name="original_authorName" Type="String" />
                <asp:Parameter Name="authorName" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
