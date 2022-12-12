<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BooksDetailView.aspx.cs" Inherits="LMSWebApp.BooksDetailView" %>

<%@ Register Src="~/Footer.ascx" TagPrefix="uc1" TagName="Footer" %>
<%@ Register Src="~/Header.ascx" TagPrefix="uc1" TagName="Header" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/bootstrap.css">
    <link rel="stylesheet" href="CSS/GlobalStyle.css">
    <link rel="stylesheet" href="CSS/StyleHeaderFooter.css">
    <title>View Book Detail</title>
</head>
<body style="background-color: #142e84;">
    <form id="form1" runat="server">
    <div>
            <header>
                <uc1:Header runat="server" ID="Header" />
            </header>

            <div class="wrapper">
                <div class="container-fluid">
                    <div class="row justify-content-center">
                        <div class="col">
                            <ul class="nav nav-tabs">
                                <li class="nav-item">
                                    <a class="nav-link active"
                                        href="BooksDetailView.aspx">View Book Detail</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link"
                                        href="BooksDetailEdit.aspx">Edit Book Detail</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link"
                                        href="BooksDetailDelete.aspx">Delete Book</a>
                                </li>                               
                            </ul>
                        </div>
                    </div>
                </div>

                <div class="panel">
                    <br />
                    <div class="panel-body">
                        <label for="" class="input-heading">Book Id</label>
                        <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
                        <span>
                            <asp:Label ID="LblExceptionId" runat="server" Text="" Visible="false"></asp:Label>
                        </span>
                        <asp:Button ID="BtnFind" runat="server" Text="Find" CssClass="button" OnClick="BtnFind_Click"/>
                    </div>
                    <br />
                </div>

                <div class="panel">
                    <br>
                    <div class="panel-head">
                        <div class="row">
                            <div class="col">
                                <label for="">View Book Detail</label>
                            </div>
                        </div>
                    </div>

                    <div class="panel-body">
                        <div class="container-fluid">
                            <div class="row">
                                <div class="col-12">
                                    <div class="form-group">
                                        <label for="" class="input-heading">Book Name</label>
                                        <asp:TextBox ID="TxtBookName" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            
                            <div class="row">
                                <div class="col-6">
                                    <div class="form-group">
                                        <label for="" class="input-heading">Category</label>
                                        <br>
                                        <asp:TextBox ID="TxtCategory" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-6">
                                    <div class="form-group">
                                        <label for="" class="input-heading">Author Name</label>
                                        <br>
                                        <asp:TextBox ID="TxtAuthor" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-6">
                                    <div class="form-group">
                                        <label for="" class="input-heading">Publisher</label>
                                        <br>
                                        <asp:TextBox ID="TxtPublisher" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                                
                                <div class="col-6">
                                    <div class="form-group">
                                        <label for="" class="input-heading">Language</label>
                                        <br>
                                        <asp:TextBox ID="TxtLanguage" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-6">
                                    <div class="form-group">
                                        <label for="" class="input-heading">Book Pages</label>
                                        <asp:TextBox ID="TxtBookPages" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-6">
                                    <div class="form-group">
                                        <label for="" class="input-heading">Quantity</label>
                                        <asp:TextBox ID="TxtQty" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-6">
                                    <div class="form-group">
                                        <label for="" class="input-heading">Cabinet No.</label>
                                        <br>
                                        <asp:TextBox ID="TxtCabinet" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-6">
                                    <div class="form-group">
                                        <label for="" class="input-heading">Shelve No.</label>
                                        <br>
                                        <asp:TextBox ID="TxtShelve" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <br>
                </div>
            </div>

            <footer>
                <uc1:Footer runat="server" ID="Footer" />
            </footer>
        </div>
    </form>
</body>
</html>
