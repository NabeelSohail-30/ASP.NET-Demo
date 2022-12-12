<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="C14_MainFile.aspx.cs" Inherits="CsharpWebAppDemo.C14_MainFile" %>

<%@ Register Src="~/C14_HeaderControl.ascx" TagPrefix="uc1" TagName="C14_HeaderControl" %>
<%@ Register Src="~/C14_FooterControl.ascx" TagPrefix="uc1" TagName="C14_FooterControl" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>

    <style>
        * {
            margin: 0px;
            padding: 0px;
            text-decoration: none;
            box-sizing: border-box;
            font-family: 'Roboto', sans-serif;
        }

        body {
            background-color: whitesmoke;
        }
        /*-----------Navigation Bar ----------*/

        nav {
            background-color: #162b6f;
            height: 90px;
            color: white;
            width: 100%;
            margin: 0px;
            padding-top: 6px;
        }

        label.logo {
            color: white;
            font-size: 35px;
            line-height: 70px;
            padding: 0 100px;
            font-weight: bold;

        }

        nav ul {
            float: right;
            margin-right: 30px;
            padding: 0 100px;
        }

        nav ul li {
            padding-top: 2px;
            display: inline-block;
            line-height: 65px;
            margin: 0px 10px;
        }

        nav ul li a {
            color: white;
            font-size: 18px;
            font-weight: bold;
            padding: 10px;
            border-radius: 3px;
        }

        nav ul li a:hover {
            color: white;
            font-size: 18px;
            font-weight: bold;
            padding: 10px;
            border-radius: 3px;
            text-decoration: underline;
        }

        .footer {
            width: 100%;
            height: 80px;
            background-color: #162b6f;
            color: white;
            display: flex;
            justify-content: center;
            align-items: center;
            text-align: center;
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:C14_HeaderControl runat="server" id="C14_HeaderControl" />
        <table style="width:100%;">
            <thead>
                <tr>
                    <th>
                    </th>
                </tr>
            </thead>

            <tbody>
                <tr>
                    <td>
                        <h4>
                            orem ipsum dolor sit amet, consectetur adipiscing elit. Nullam ut gravida augue. Suspendisse nisi ante, sodales at massa eu, iaculis vehicula tortor. Nulla nec mi sed lectus vehicula porta non nec felis. Sed aliquam maximus scelerisque. Mauris sed placerat velit, vitae placerat ex. Suspendisse commodo massa ac ante commodo fermentum. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nullam dignissim ex metus. Donec sem lorem, imperdiet vel dolor a, molestie rutrum ligula. Integer placerat quis ex vel hendrerit. Curabitur quis posuere enim.

Duis eleifend commodo purus. Maecenas lobortis dui non nibh molestie, sed laoreet nibh mollis. Nulla mollis odio diam, in blandit eros mattis ac. Pellentesque in blandit dolor. Praesent consectetur viverra metus, consequat dictum diam pharetra in. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque scelerisque elit a lacus pulvinar eleifend. Duis in nibh ac augue mollis feugiat. Sed luctus at quam ut porttitor. Quisque at sollicitudin risus. Maecenas eget justo id justo hendrerit interdum. Nunc urna urna, dapibus quis nibh non, pellentesque fringilla sapien. Nullam turpis ligula, faucibus sit amet turpis vel, molestie ornare eros. Integer vitae leo hendrerit lorem cursus blandit sit amet ac mi. Suspendisse quis tempor sem.

Suspendisse nec orci a ligula pharetra viverra. Ut interdum mattis neque eu rhoncus. Quisque eleifend viverra mattis. Duis dapibus sem eget lacinia ullamcorper. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; In hac habitasse platea dictumst. Maecenas a nibh suscipit, dapibus nunc vitae, placerat tellus. Maecenas eu feugiat massa. Maecenas accumsan volutpat dolor in tincidunt. Donec eu consequat massa. Donec eu consequat urna, vel eleifend ipsum. Phasellus ut augue iaculis, auctor dui ac, ullamcorper turpis. Nunc porttitor lectus et efficitur venenatis. Curabitur sodales dictum iaculis. Integer maximus fermentum massa eget tincidunt.
                        </h4>
                    </td>
                </tr>
            </tbody>

            <tfoot>
                <tr>
                    <td>
                        <uc1:C14_FooterControl runat="server" id="C14_FooterControl" />
                    </td>
                </tr>
            </tfoot>
        </table>
    </div>
    </form>
</body>
</html>
