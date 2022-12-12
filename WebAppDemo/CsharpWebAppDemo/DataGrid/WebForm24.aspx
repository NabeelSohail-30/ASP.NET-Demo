<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm24.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm24" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <table border="1">
                    <tr>
                        <td>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("ImageURL") %>' />
                        </td>
                        <td>
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("AuthorId") %>'></asp:Label>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("AuthorName") %>'></asp:Label>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Active") %>'></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
            <SeparatorTemplate>
                <hr />
            </SeparatorTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
