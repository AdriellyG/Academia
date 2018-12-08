<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage2.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Paginas_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <style>
        body {
            height: 100%;
            background-color: |#808080;
        }

        #cover {
            color: white;
            height: 100%;
            text-align: center;
            display: flex;
            align-items: center;
        }

        #cover-caption {
            width: 100%;
        }
        .nopadding{
            margin-top: 0;
        }
    </style>

    <form>
        <br />
        <br />
        <div class="jumbotron nopadding">
            <h1 class="text-center">ADS - Academia</h1>
            <h3 class="text-center">Venha ficar monstrão!</h3>
        </div>
        <br />
        <br />
        <br />
        <section id="cover">
            <div id="cover-caption">
                <div class="container">

                    <div class="col-sm-3 my-1 mx-auto">
                        <label class="sr-only" for="txtUsuario">Usuário</label>
                        <div class="input-group">
                            <div class="input-group-prepend">
                                <div class="input-group-text">E-mail</div>
                            </div>
                            <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server" placeholder="Usuário"></asp:TextBox>

                        </div>
                    </div>
                    <div class="form-group mx-auto">
                        <div class="col-sm-3 my-1 mx-auto">
                            <label class="sr-only" for="txtSenha">Senha</label>
                            <div class="input-group">
                                <div class="input-group-prepend">
                                    <div class="input-group-text">Senha</div>
                                </div>
                                <asp:TextBox ID="txtSenha" CssClass="form-control" runat="server" TextMode="Password" placeholder="Senha"></asp:TextBox>
                            </div>
                            <br/>
                            <asp:Button ID="btnEntrar" CssClass="btn btn-primary" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
                        </div>
                    </div>
        </section>
    </form>
</asp:Content>