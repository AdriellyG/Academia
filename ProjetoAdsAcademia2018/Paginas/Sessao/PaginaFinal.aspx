<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="PaginaFinal.aspx.cs" Inherits="Paginas_Sessao_PaginaFinal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1>Pagina Final</h1>
    <asp:Label ID="lblNome" runat="server"></asp:Label>
    <asp:Button ID="btnVoltar" runat="server" Text="VOLTAR" OnClick="btnVoltar_Click" />
    <asp:Button ID="btnSair" runat="server" Text="SAIR" OnClick="btnSair_Click" />
</asp:Content>

