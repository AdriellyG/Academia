<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="PaginaIncial.aspx.cs" Inherits="Paginas_Sessao_PaginaIncial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
    <asp:Button ID="btn" runat="server" Text="LOGIN" OnClick="btn_Click"/>
</asp:Content>

