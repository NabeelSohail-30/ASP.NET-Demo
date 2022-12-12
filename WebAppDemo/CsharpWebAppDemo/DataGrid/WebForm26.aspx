<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm26.aspx.cs" Inherits="CsharpWebAppDemo.DataGrid.WebForm26" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Chart ID="Chart1" runat="server" style="direction: ltr">

            <Series>
                <asp:Series Name="Series1" ChartArea="ChartArea1">

                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                    
                    <AxisY Title="Marks">
                    </AxisY>
                    <AxisX Title="Student">
                    </AxisX>
                    
                </asp:ChartArea>
            </ChartAreas>
            <Titles>
                <asp:Title Name="Title1" Text="Student Marks">
                </asp:Title>
            </Titles>
        </asp:Chart>
    </div>
    </form>
</body>
</html>
