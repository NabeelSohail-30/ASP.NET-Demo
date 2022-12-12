<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C10HyperLink.aspx.cs" Inherits="CsharpWebAppDemo.C10HyperLink" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Hyperlink Control</h1>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.w3schools.com/" Target="_blank">W3 School</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" ImageHeight="60px" ImageUrl="~/Images/Google.png" NavigateUrl="https://www.Google.com">Google</asp:HyperLink>
        <br />
    </div>
    </form>
</body>
</html>
