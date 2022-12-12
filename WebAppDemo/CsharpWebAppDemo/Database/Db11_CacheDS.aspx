<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Db11_CacheDS.aspx.cs" Inherits="CsharpWebAppDemo.Database.Db11_CacheDS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Cache Data Set</h1>
        
        Cache means store data temp. in computer memory.<br />
        <br />
        Why Cache Data Set is required???<br />
        In Somecases data will not change on frequent basis, in this case we dont need to load load from the DB everytime. Better to store into Cache and use the Cache data for next refresh.
        
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Reload" Width="85px" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear Cache" Width="84px" />
        </p>
        <p>
            <asp:Label ID="LblMessage" runat="server"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TxtSearch" runat="server" Height="25px" Width="159px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" />
        </p>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
