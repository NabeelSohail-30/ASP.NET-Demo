<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm16.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm16" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../scripts/jquery-3.6.0.min.js"></script>
</head>
    <script>
        function toggleSelectionUsingHeaderCheckBox(source)
        {
            //Get All Gridview Checkboxes items whose names ends with ckselect.
            $("#GridView1 input[name$='ckSelect']").each(function () {
                $(this).attr('checked', source.checked);
            });
        }

        function toggleSelectionOfHeaderCheckBox() {
            //alert('function called');
            if ($("#GridView1 input[name$='ckSelect']").length == $("#GridView1 input[name$='ckSelect']:checked").length) {
                //$("#GridView1 input[name$='ckSelectAll']").first().attr('checked', true);
                $("#GridView1_ckSelectAll").attr('checked', true);
            }
            else {
                //$("#GridView1 input[name$='ckSelectAll']").first().attr('checked', false);
                $("#GridView1_ckSelectAll").attr('checked', false);
            }
        }

        $(document).ready(function () {
            $("#Button1").click(function () {
                var rowsSelected = $("#GridView1 input[name$='ckSelect']:checked").length;
                if (rowsSelected == 0) {
                    alert('No Rows selected');
                }
                else {
                    return confirm(rowsSelected + ' rows will be deleted');
                }
            });
        });
    </script>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        <asp:CheckBox ID="ckSelectAll" runat="server" onclick="toggleSelectionUsingHeaderCheckBox(this);"/>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="ckSelect" runat="server" onclick="toggleSelectionOfHeaderCheckBox();"/>
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
        <asp:Button ID="Button1" runat="server" Text="Delete" />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllAuthors" TypeName="CsharpWebAppDemo.Database.Models.Author"></asp:ObjectDataSource>
    </form>
</body>
</html>
