<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm25.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm25" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
        </div>
        <asp:Chart ID="Chart1" runat="server" BackColor="InactiveCaption" BorderlineColor="Transparent" Height="349px" Width="618px">
            <Titles>
                <asp:Title Text="Total Sdents Marks" />
            </Titles>
            <Series>
                <asp:Series Name="Series1" ChartArea="ChartArea1" ChartType="Bar" YValuesPerPoint="2">
                    <Points>
                        <asp:DataPoint AxisLabel="Nabeel" YValues="850,0" />
                        <asp:DataPoint AxisLabel="Ali" YValues="755,0" />
                        <asp:DataPoint AxisLabel="Ahmed" YValues="450,0" />
                        <asp:DataPoint AxisLabel="Jawed" YValues="820,0" />
                        <asp:DataPoint AxisLabel="Salik" YValues="732,0" />
                        <asp:DataPoint AxisLabel="Daniyal" YValues="460,0" />
                        <asp:DataPoint AxisLabel="Salman" YValues="700,0" />

                    </Points>
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX Title="Stdent Name"></AxisX>
                    <AxisY Title="Student Marks"></AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </form>
</body>
</html>
