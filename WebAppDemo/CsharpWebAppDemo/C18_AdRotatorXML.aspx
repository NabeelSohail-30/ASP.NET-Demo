<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C18_AdRotatorXML.aspx.cs" Inherits="CsharpWebAppDemo.C18_AdRotatorXML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Filter" />
        <br />
        
    </div>
        <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Data/AdsData.xml" Target="_blank" />
    </form>
</body>
</html>
