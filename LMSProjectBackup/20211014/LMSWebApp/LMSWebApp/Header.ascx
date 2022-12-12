<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="LMSWebApp.Header" %>
<div class="container-fluid User-Detail">
    <div class="row">
        <div class="col-8">
            <ul>
                <li><asp:Label ID="LblUserDetail" runat="server" Text="Welcome Nabeel"></asp:Label></li>
            </ul>
        </div>
        <div class="col-4">
            <ul>
                <li><asp:Label ID="LblDateTime" runat="server" Text="20/5/2020"></asp:Label></li>
            </ul>
        </div>
    </div>
</div>
<nav>
    <label class="logo">Library Management System</label>
    <ul>
        <li>
            <a href="Dashboard.aspx" class="active">Home</a>
        </li>

        <li>
            <a href="BooksDetail.aspx">Books</a>
        </li>

        <li>
            <a href="#">Author</a>
        </li>

        <li>
            <a href="#">Publisher</a>
        </li>
    </ul>
</nav>