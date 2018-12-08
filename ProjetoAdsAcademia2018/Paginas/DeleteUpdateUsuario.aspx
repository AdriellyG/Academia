<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="DeleteUpdateUsuario.aspx.cs" Inherits="Paginas_DeleteUpdateUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        :root{
                    --widthCelula: 14%;

                }

    </style>
    <h1 class="jumbotron">Update e delete usuário</h1>
    <div class="container">
            <br />
            <div class="row">
                <div class="col-md-6">
                    <label>Nome: </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;
                    <asp:dropdownlist id="ddlUsuario" CssClass="form-control" runat="server"></asp:dropdownlist>
                    <br />
                    <br />

                    <label>Perfil: </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="ddlPerfil" CssClass="form-control" runat="server"></asp:DropDownList>
                    <br />
                    <br />
                </div>
                <div class="col-md-6">
                    <label>Data de Cadastro: </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtData" CssClass="form-control" runat="server" type="Date"></asp:TextBox>
                    <br /><br />
                </div>

                <div class="col-md-6">
                    <label>Login: </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtLogin" CssClass="form-control" runat="server" TextMode="Email"></asp:TextBox>
                    <br />
                    <br />
                </div>
                <div class="col-md-6">
                    <label>Senha: </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtSenha" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                      <asp:Label ID="lblSenha" runat="server"></asp:Label>
                    
                    <br/><br/>
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
        </div>
</asp:Content>