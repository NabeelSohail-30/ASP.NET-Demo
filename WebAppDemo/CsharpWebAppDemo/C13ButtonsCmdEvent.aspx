<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C13ButtonsCmdEvent.aspx.cs" Inherits="CsharpWebAppDemo.C13ButtonsCmdEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Buttons Command Events</h1>
        <br />
        ASP.Net button control exposes two Events. Means wheenver we click on Button, ASP.Net will fires two Events.<br />
        1. Click Event (First)<br />
        2. Command Event (Second)<br />
        <br />
        Whey do we use Command Event?<br />
        We can perform&nbsp; more than one Button task only using One Command Button Event.<br />
        <br />
        CommandName Property: We can define CommandName to our Buttons and can validate by using CommandName Property. Same CommandName can be define to one ore more Command Buttons.<br />
        <br />
        CommandArgument Property can be used to distinguish same CommandName Buttons.<br />

        <p>
            <h3>Button Click and Command Event Example</h3>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" OnCommand="Button1_Command"/>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Add" CommandName="Add" OnCommand="CheckButtons" Width="79px" />
        <br />
        <br />
            <asp:Button ID="Button3" runat="server" Text="Edit" CommandName="Edit" Width="81px" OnCommand="CheckButtons" CommandArgument="CmdEdit"/>
        <br />
        <br />
            <asp:Button ID="Button4" runat="server" Text="View" CommandName="View" Width="79px" OnCommand="CheckButtons"/>
        <br />
        <br />
            <asp:Button ID="Button5" runat="server" Text="Delete" CommandName="Delete" Width="81px" OnCommand="CheckButtons"/>
        <br />
        <br />
            <asp:Button ID="Button6" runat="server" Text="Print" CommandName="Edit" Width="81px" OnCommand="CheckButtons" CommandArgument="CmdPrint"/>
        <br />
        </p>
    </div>
    </form>
</body>
</html>
