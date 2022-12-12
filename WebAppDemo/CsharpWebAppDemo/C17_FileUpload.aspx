<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C17_FileUpload.aspx.cs" Inherits="CsharpWebAppDemo.C17_FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Upload File"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        <br />
        <br />
        <br />
        <asp:Label ID="LblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server">Download</asp:HyperLink>
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Load Img" />
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" />
        <br />
        <br />
        <br />
    <div>
        
    </div>
    </form>
</body>
</html>
