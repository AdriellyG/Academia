<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="LabelDinamico.aspx.cs" Inherits="Paginas_LabelDinamico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">

        <asp:Label ID="lblNome" runat="server" Text="Label"></asp:Label>

        <asp:Literal ID="lbl" runat="server"></asp:Literal>

        <asp:Literal ID="tabela" runat="server"></asp:Literal>
    </div>
    
</asp:Content>

