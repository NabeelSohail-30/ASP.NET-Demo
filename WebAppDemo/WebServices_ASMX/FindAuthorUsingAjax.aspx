<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FindAuthorUsingAjax.aspx.cs" Inherits="WebServices_ASMX.FindAuthorUsingAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>AJAX Example Web Form</h1>
        <h3>
            <asp:Label ID="lblServer" runat="server" Text=""></asp:Label>
        </h3>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/Author.asmx" />
            </Services>
        </asp:ScriptManager>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Author Id"></asp:Label>
        <asp:TextBox ID="id" runat="server"></asp:TextBox>
        <input id="Button1" type="button" value="Find" onclick="findAuthorById();" />
        <br />

        <asp:Label ID="Label2" runat="server" Text="Author Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="Label3" runat="server" Text="Author Id"></asp:Label>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <br />

        <script>
            function findAuthorById() {
                var id = document.getElementById("id").value;
                WebServices_ASMX.Author.Find(id, GetAuthorByIdSuccessCallback, GetAuthorByIdFailedCallBack);
            }

            function GetAuthorByIdSuccessCallback(result) {
                document.getElementById('txtName').value = result["AuthorName"];
                document.getElementById('txtId').value = result["AuthorId"];
            }

            function GetAuthorByIdFailedCallBack(error) {
                window.alert(error.get_message());
            }
        </script>
    </div>
    </form>
</body>
</html>
