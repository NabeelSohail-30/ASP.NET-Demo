<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C10_CalanderControl.aspx.cs" Inherits="CsharpWebAppDemo.C10_CalanderControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            font-weight: 700;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
        <asp:Label ID="Label1" runat="server" Text="Date"></asp:Label>
        <asp:TextBox ID="TxtDate" runat="server"></asp:TextBox>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/calendar.png" OnClick="ImageButton1_Click" Width="25px" />
        <asp:Calendar ID="Calendar1" runat="server" Caption="Select Date" CaptionAlign="Right" FirstDayOfWeek="Sunday" NextMonthText="Next" NextPrevFormat="ShortMonth" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" OnVisibleMonthChanged="Calendar1_VisibleMonthChanged" PrevMonthText="Prev" SelectedDate="03/07/2022 11:00:23" SelectionMode="DayWeekMonth">
            <DayHeaderStyle BackColor="#9966FF" />
            <DayStyle BackColor="#99CCFF" />
            <NextPrevStyle BackColor="#CC6699" />
        </asp:Calendar>
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TxtShortDate" runat="server" Width="206px"></asp:TextBox>
        <asp:TextBox ID="TxtLongDate" runat="server" Width="206px"></asp:TextBox>
        <asp:TextBox ID="TxtShortTime" runat="server" Width="206px"></asp:TextBox>
        <asp:TextBox ID="TxtLongTime" runat="server" Width="206px"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtCustom" runat="server" Width="206px"></asp:TextBox>
    </form>
</body>
</html>
