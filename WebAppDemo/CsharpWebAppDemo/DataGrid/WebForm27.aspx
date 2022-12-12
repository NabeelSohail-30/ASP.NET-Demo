<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm27.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm27" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Chart ID="Chart1" runat="server" Style="direction: ltr" Height="419px" Width="668px">

                <Series>
                    <asp:Series Name="Series1" ChartArea="ChartArea1">
                        <Points>
                        </Points>
                    </asp:Series>
                </Series>

                <ChartAreas>

                    <asp:ChartArea Name="ChartArea1">
                        <Area3DStyle Enable3D="true" LightStyle="Realistic" />
                        <AxisY Title="Qty">
                        </AxisY>
                        <AxisX Title="Author">
                        </AxisX>

                    </asp:ChartArea>
                </ChartAreas>

                <Titles>
                    <asp:Title Name="Title1" Text="Author">
                    </asp:Title>
                </Titles>
            </asp:Chart>
        </div>
    </form>
</body>
</html>
