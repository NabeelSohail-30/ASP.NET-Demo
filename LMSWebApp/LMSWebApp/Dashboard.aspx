<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="LMSWeb.Dashboard" %>

<%@ Register Src="~/Header.ascx" TagPrefix="uc1" TagName="Header" %>
<%@ Register Src="~/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/bootstrap.css">
    <link rel="stylesheet" href="CSS/GlobalStyle.css">
    <link rel="stylesheet" href="CSS/StyleHome.css">
    <link rel="stylesheet" href="CSS/StyleHeaderFooter.css">
    <title>Main Menu</title>
</head>
<body>
    <form id="form1" runat="server">
    <header>
        <uc1:Header runat="server" ID="Header" />
    </header>
    <div class="banner">
    <div class="head">
        <div class="title">
            My Home
            <br>
            Library Management System
        </div>

        <div class="logo">
            <img src="Images/alfons-morales-YLSwjSy7stw-unsplash.jpg" alt="">
        </div>
    </div>
    </div>

    <div class="dashboard">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-4">
                    <div class="card text-center">
                        <img class="card-img-top" src="Images/Card01.jpg" alt="Card image"
                            style="width: 100%; height: 280px;">

                        <div class="card-body">
                            <h4 class="card-title">Books</h4>
                            <a href="#" class="card-btn">Click Here</a>
                        </div>
                    </div>
                </div>

                <div class="col-4">
                    <div class="card text-center">
                        <img class="card-img-top" src="Images/Card02.jpg" alt="Card image"
                            style="width: 100%; height: 280px;">

                        <div class="card-body">
                            <h4 class="card-title">Author</h4>
                            <a href="#" class="card-btn">Click Here</a>
                        </div>
                    </div>
                </div>

                <div class="col-4">
                    <div class="card text-center">
                        <img class="card-img-top" src="Images/Card03.jpg" alt="Card image"
                            style="width: 100%; height: 280px;">

                        <div class="card-body">
                            <h4 class="card-title">Publisher</h4>
                            <a href="#" class="card-btn">Click Here</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
        <footer>
            <uc1:Footer runat="server" id="Footer" />
        </footer>
    </form>
</body>
</html>
