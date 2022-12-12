<%@ Page Title="" Language="C#" MasterPageFile="~/C36_Site.Master" AutoEventWireup="true" CodeBehind="C36_Content01.aspx.cs" Inherits="CsharpWebAppDemo.C36_Content01" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Content Page 01</h1>
    Email
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    Name
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" />
</asp:Content>
