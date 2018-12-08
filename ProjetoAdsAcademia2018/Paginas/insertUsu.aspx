<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="insertUsu.aspx.cs" Inherits="Paginas_insertUsu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        :root{
                    --widthCelula: 14%;

                }

    </style>
            <h1 class="jumbotron">Cadastro Usuário</h1>
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

                    
                    <br/><br/>
                </div>

                <div class="col-md-12">
                    <asp:Button ID="btnCadastro" class="btn btn-primary" runat="server" Text="CADASTRAR" OnClick="btnCadastro_Click" />
                    <br/>
                    <br/>
                    <br/>
                </div>

                <div class="col-md-12">
                    <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
                    <br />
                    <br />
                </div>
                <div class="col-md-12">
                    <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="False" BackColor="Gray" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:BoundField DataField="pes_nome" HeaderText="Nome" />
                            <asp:BoundField DataField="pes_cpf" HeaderText="CPF" />
                            <asp:BoundField DataField="pes_rg" HeaderText="RG" />
                            <asp:BoundField DataField="usu_email" ControlStyle-CssClass="col-md-2" HeaderText="Email" />
                            <asp:BoundField DataField="usu_datacadastro" HeaderText="Data de Cadastro" />
                            <asp:BoundField DataField="per_descricaoPerfil" HeaderText="Perfil" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </div>
                <br />
                <div class="col-md-12">
                    <asp:Label ID="lblGrid" runat="server" Text="---"></asp:Label>
                </div>

            </div>
        </div>
</asp:Content>

