<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C02WebAppLifeCycleEvents.aspx.cs" Inherits="CsharpWebAppDemo.C02WebAppLifeCycleEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h2>Events in the life cycle of Web Applicaiton</h2>
    <p>Events can occur at 3 Levels.</p>
<p>1. Application Level (Global.asax)</p>
<p>2. Page Level (Web Form - *.aspx pages) </p>
<p>3. Control Level (TextBox, Buttons, etc.)</p>
    <form id="form1" runat="server">
    <div>
    <h3>Page Level Event Handling</h3>
    </div>
        <asp:Button ID="Button1" runat="server" OnLoad="Button1_Load" Text="Button" Width="247px" />
    </form>
</body>
</html>
