<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Db10_Disconnected.aspx.cs" Inherits="CsharpWebAppDemo.Database.Db10_Disconnected" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Insert Rows in Data Set/Data Table</h1>


        <asp:Label ID="lblCount" runat="server" Text=""></asp:Label>
        <br />
        <br />

        <asp:Label ID="Label2" runat="server" Text="Author Name"></asp:Label>
        <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>
        <asp:Button ID="btnSave" runat="server" Text="Save Author" OnClick="btnSave_Click" />
        <asp:Button ID="btnRow" runat="server" Text="New Row" OnClick="btnRow_Click" />
        <asp:Button ID="btnDBupdate" runat="server" Text="Update DB" OnClick="btnDBupdate_Click" />

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        
    </div>
    </form>
</body>
</html>
