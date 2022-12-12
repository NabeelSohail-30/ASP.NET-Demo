<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CsharpWebAppDemo.RegistrationForm02.Index" %>

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
        <div class="wrapper">
            <div class="container">
                <div class="row">
                    <div class="col form-head">
                        <h1>Registration Form</h1>
                    </div>
                </div>

                <div class="row">
                    <div class="col-6">
                        <div class="form-group">
                            <label for="" class="input-heading">First Name</label>
                            <asp:TextBox ID="TxtFirstName" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-6">
                        <div class="form-group">
                            <label for="" class="input-heading">Last Name</label>
                            <asp:TextBox ID="TxtLastName" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-6">
                        <div class="form-group">
                            <label for="" class="input-heading">Gender</label>
                            <asp:DropDownList ID="DdListGender" runat="server" class="form-control">
                                <asp:ListItem>Select Gender</asp:ListItem>
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                                <asp:ListItem>Others</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>

                    <div class="col-6">
                        <div class="form-group">
                            <label for="" class="input-heading">Nationality</label>
                            <asp:DropDownList ID="DdNationality" runat="server" CssClass="form-control">
                                <asp:ListItem>Pakistani</asp:ListItem>
                                <asp:ListItem>Kuwaiti</asp:ListItem>
                                <asp:ListItem>British</asp:ListItem>
                                <asp:ListItem>Turkish</asp:ListItem>
                                <asp:ListItem>Indian</asp:ListItem>
                                <asp:ListItem>American</asp:ListItem>
                                <asp:ListItem>Korean</asp:ListItem>
                                <asp:ListItem>Canadian</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-6">
                        <div class="form-group">
                            <label for="" class="input-heading">Mobile Number</label>
                            <asp:TextBox ID="TxtMobileNumber" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-6">
                        <div class="form-group">
                            <label for="" class="input-heading">Email Address</label>
                            <asp:TextBox ID="TxtEmail" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col">
                        <div class="form-group">
                            <label for="" class="input-heading">Address</label>
                            <asp:TextBox ID="TxtAddress" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col d-flex justify-content-center">
                        <div class="form-group">
                            <asp:Button ID="BtnSubmit" runat="server" Text="Submit" CssClass="button" OnClick="BtnSubmit_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

</body>

</html>
