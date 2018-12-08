<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="DeleteUpdate_Endereco.aspx.cs" Inherits="Paginas_DeleteUpdate_Endereco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <br />
    <br />
    <h1 class="jumbotron">Update e delete endereço</h1>
    <section class="container">
        <div class="row">
            <div class="col-md-12 text-center">
            </div>
            <asp:Label ID="lblCodigoPessoa" runat="server" Visible="false"></asp:Label>
            <div class="col-md-6">
                <label>Nome: </label>
                <asp:DropDownList ID="ddlPessoa" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlPessoa_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:Label ID="lblpessoa" runat="server"></asp:Label>
                <br />
            </div>

            <div class="col-md-6">
                <label>Rua:</label>
                <asp:TextBox runat="server" ID="txtRua" CssClass="form-control" />
                <br />
            </div>

            <div class="col-md-6">
                <label>Número:</label>
                <asp:TextBox runat="server" ID="txtNumero" CssClass="form-control" />
                <br />
            </div>
            <div class="col-md-6">
                <label>Bairro:</label>
                <asp:TextBox runat="server" ID="txtBairro" CssClass="form-control" />
                <br />
            </div>
            <div class="col-md-6">
                <label>Cidade:</label>
                <asp:TextBox runat="server" ID="txtCidade" CssClass="form-control" />
                <br />
            </div>
            <div class="col-md-6">
                <label>Estado:</label>
                <asp:TextBox runat="server" ID="txtEstado" CssClass="form-control" />
                <br />
            </div>
            <div class="col-md-6">
                <label>CEP:</label>
                <br />
                <div class="form-inline">
                    <asp:TextBox runat="server" ID="txtCEP" CssClass="form-control" />
                </div>

            </div>

            <div class="col-md-6">
                <br />
                <asp:Button Text="Alterar" runat="server" ID="btn" OnClick="btn_Click" CssClass="btn btn-primary" />
                <asp:Button Text="Deletar" runat="server" ID="btnDeletar" OnClick="btnDeletar_Click" CssClass="btn btn-danger ml-2" />
                <br />
            </div>

            <div class="col-md-12">
                <asp:Label ID="lblMSG" runat="server" Text="---"></asp:Label>
            </div>
        </div>

    </section>


</asp:Content>

