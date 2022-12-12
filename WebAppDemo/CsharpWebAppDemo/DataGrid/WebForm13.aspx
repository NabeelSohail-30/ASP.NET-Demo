<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm13.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="AuthorId" ShowFooter="True" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:LinkButton ID="btnUpdate" runat="server" CommandName="UpdateRow" CommandArgument='<%# Bind("AuthorId") %>'>Update </asp:LinkButton>
                        <asp:LinkButton ID="btnCancel" runat="server" CommandName="CancelUpdate" CommandArgument='<%# Bind("AuthorId") %>'>Cancel</asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEdit" runat="server" CommandName="EditRow" CommandArgument='<%# Bind("AuthorId") %>'>Edit    </asp:LinkButton>
                        <asp:LinkButton ID="btnDel" runat="server" CommandName="DeleteRow" CommandArgument='<%# Bind("AuthorId") %>'>Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="AuthorId">
                    <EditItemTemplate>
                        <asp:Label ID="lblAuthorId" runat="server" Text='<%# Bind("AuthorId") %>'></asp:Label>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:LinkButton ID="btnSave" runat="server" CommandName="InsertRow">Save</asp:LinkButton>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("AuthorId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="AuthorName">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtUpdateAuthor" runat="server" Text='<%# Bind("AuthorName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("AuthorName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Gender">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddUpdateGender" runat="server" SelectedValue='<%# Eval("Gender") %>'>
                            <asp:ListItem>Select Gender</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="ddGender" runat="server">
                            <asp:ListItem>Select Gender</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Active">
                    <EditItemTemplate>
                        <asp:CheckBox ID="ckUpdateActive" runat="server" Checked='<%# Bind("Active") %>'></asp:CheckBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:CheckBox ID="ckActive" runat="server" />
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Active") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField Text="&lt;img src='../Images/CSharp.png' width='25px' height='25px' /&gt;" DataNavigateUrlFields="AuthorId" DataNavigateUrlFormatString="Sample.aspx?id={0}" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="Label5" runat="server" Text='<%# Bind("AuthorName") %>' CommandName="ViewRecord" CommandArgument='<%# Bind("AuthorId") %>'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
