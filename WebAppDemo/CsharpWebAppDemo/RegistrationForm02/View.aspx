<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="CsharpWebAppDemo.RegistrationForm02.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registration Form</title>
    <link rel="stylesheet" href="CSS/bootstrap.css">
</head>
<style>
    * {
        margin: 0px;
        padding: 0px;
        text-decoration: none;
        box-sizing: border-box;
        font-family: 'Roboto', sans-serif;
    }

    body {
        background-color: lightblue;
    }

    .wrapper {
        width: 50%;
        height: max-content;
        background-color: whitesmoke;
        color: black;
        margin: 40px auto;
    }

    .form-head {
        font-size: 26px;
        font-weight: bold;
        text-align: center;
        padding-top: 10px;
    }

    .input-heading {
        font-size: 16px;
        font-weight: 500;
    }

    .button {
        background-color: #162b6f;
        padding: 10px 22px;
        font-size: 22px;
        border: 0px;
        outline: 0px;
        border-radius: 20px;
        color: whitesmoke;
        font-weight: bold;
    }

    .button {
        background-color: #142e84;
        padding: 10px 22px;
        font-size: 22px;
        border: 0px;
        outline: 0px;
        border-radius: 20px;
        color: whitesmoke;
        font-weight: bold;
        text-decoration: none;
    }
</style>

<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
        <div class="wrapper">
        <div class="container">
            <div class="row">
                <div class="col form-head">
                    <h1>Detail</h1>
                </div>
            </div>

            <div class="row">
                <div class="col-6">
                    <div class="form-group">
                        <asp:TextBox ID="FirstName" runat="server" CssClass="form-control" Enabled="False">
                        </asp:TextBox>
                    </div>
                </div>

                <div class="col-6">
                    <div class="form-group">
                        <asp:TextBox ID="LastName" runat="server" CssClass="form-control" Enabled="False">
                        </asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-6">
                    <div class="form-group">
                        <asp:TextBox ID="Gender" runat="server" CssClass="form-control" Enabled="False">
                        </asp:TextBox>
                    </div>
                </div>

                <div class="col-6">
                    <div class="form-group">
                        <asp:TextBox ID="Nationality" runat="server" CssClass="form-control" Enabled="False">
                        </asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-6">
                    <div class="form-group">
                        <asp:TextBox ID="MobileNumber" runat="server" CssClass="form-control" Enabled="False">
                        </asp:TextBox>
                    </div>
                </div>

                <div class="col-6">
                    <div class="form-group">
                        <asp:TextBox ID="EmailAddress" runat="server" CssClass="form-control" Enabled="False">
                        </asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col">
                    <div class="form-group">
                        <asp:TextBox ID="Address" runat="server" CssClass="form-control" Enabled="False">
                        </asp:TextBox>
                    </div>
                </div>
            </div>
        </div>
        </div>
        </asp:Panel>

    </form>

</body>

</html>
