<!--ASP .Net Page Directive-->
<%
    @ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CsharpWebAppDemo.WebForm1" 
%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Hello World, This is My First .NET Web Page</h1>
    </div>
    <p>
        This is my Paragraph.</p>
    <p>
        &nbsp;</p>
    <p>
        <span class="auto-style1"><strong>My next Paragraph</strong></span>.</p>
    <p>
        &nbsp;</p>
    <h3>New Heading</h3>
    <p>
        &nbsp;</p>

    <% Response.Write("I wrote his message using Classic ASP Response.Write Method"); %>
    <%
        
        for(int i = 0;i<5;i++)
        {
            Response.Write("<br>");
            Response.Write("Nabeel");
        }

    %>
    <table style="width:50%;">
        <tr>
            <td class="auto-style2" colspan="3"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="background-color: #808000"></td>
            <td class="auto-style2"></td>
            <td class="auto-style2"></td>
        </tr>
    </table>
        <div>
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <input id="HTMLText1" type="text" /></p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="StdTextBox1" runat="server"></asp:TextBox>
        </p>
        <div>
            Enter Name: <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

        </div>
    
        <div>
            <asp:Label ID="lblFather" Text="Enter Father Name" runat="server"></asp:Label>
            <asp:TextBox ID="txtfather" runat="server"></asp:TextBox>
        </div>
    <p>
        &nbsp;</p>

    <div>
        HTML Button
    <input id="Button1" type="button" value="button" />
    </div>
    
    <div>
        ASP.Net Button
        <asp:Button ID="Button2" runat="server" Text="Button" />
    </div>


        <div>
            HTML Table
            <table style="width: 100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>

        <div>
            ASP.NET Table
            <asp:Table ID="Table1" runat="server" Width="500px">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        </form>
</body>
</html>
