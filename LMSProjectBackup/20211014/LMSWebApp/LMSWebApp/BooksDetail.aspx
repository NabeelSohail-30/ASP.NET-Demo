<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BooksDetail.aspx.cs" Inherits="LMSWebApp.BooksDetail" %>

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
    <link rel="stylesheet" href="CSS/StyleHeaderFooter.css">
    <title>Books</title>

<style>
    .search div {
        display: inline-block;
        margin: 0px 10px;
    }
</style>
</head>

<body style="background-color: #142e84;">
    <form id="form1" runat="server">
    <div>
    <header>
        <uc1:Header runat="server" id="Header" />
    </header>
    <main>
        <section class="action">
            <div class="search">
                <div>
                    <asp:TextBox ID="TxtBookName" runat="server" CssClass="search-bar" placeholder="Search By Book Name"></asp:TextBox>
                </div>

                <div>
                    <asp:DropDownList ID="ListCategory" runat="server" CssClass="search-bar"></asp:DropDownList>
                </div>

                <div>
                    <asp:DropDownList ID="ListAuthor" runat="server" CssClass="search-bar"></asp:DropDownList>
                </div>

                <div>
                    <asp:DropDownList ID="ListPublisher" runat="server" CssClass="search-bar"></asp:DropDownList>
                </div>

                <div>
                    <asp:DropDownList ID="ListLanguage" runat="server" CssClass="search-bar"></asp:DropDownList>
                </div>

                <asp:Button ID="BtnSearch" runat="server" Text="Button" CssClass="search-btn"/>
            </div>

            <div class="btn">
                <asp:Button ID="BtnAddNewBook" runat="server" Text="Add New Book" CssClass="add-new" ToolTip="Add New Book" OnClick="BtnAddNewBook_Click"/>
            </div>

            <div class="btn">
                <asp:Button ID="Btn" runat="server" Text="Edit/View/Delete" CssClass="add-new" OnClick="Btn_Click"/>
            </div>
            
        </section>

        <section>
            <asp:GridView ID="GridBooks" runat="server">
            </asp:GridView>
        </section>
    </main>
    </div>
        <footer>
            <uc1:Footer runat="server" id="Footer" />
        </footer>
    </form>
</body>
</html>
