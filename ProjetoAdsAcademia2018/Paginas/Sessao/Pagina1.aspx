<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="Pagina1.aspx.cs" Inherits="Paginas_Sessao_Pagina1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1>Página Inicial</h1>
    <asp:Label ID="lblNome" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="btn" runat="server" Text="AVANÇAR" OnClick="btn_Click" />
</asp:Content>

