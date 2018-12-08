<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="insertEndereco.aspx.cs" Inherits="Paginas_insertEndereco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        :root{
                    --widthCelula: 11.1%;

                }

    </style>
    <h1 class="jumbotron">Cadastro Endereço</h1>
    <div class="container">
        <br />
        <div class="col-md-6">
            <label>Pessoa:</label>
             <asp:DropDownList ID="ddl" CssClass="form-control" runat="server"></asp:DropDownList>
        </div>    
        <div class="col-md-6">
            <label>CEP: </label>
            <br />   
            <div class="form-inline">
                <asp:TextBox ID="txtCEP" class="form-control" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" CssClass="btn btn-success ml-3" runat="server" Text="Buscar" OnClick="btnBuscar_Click" /><br />
            </div>
        </div>
        <div class="col-md-6">
            <label>Logradouro: </label>
            <asp:TextBox ID="txtLogradouro" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label>Número: </label>
            <asp:TextBox ID="txtNumero" class="form-control" runat="server"></asp:TextBox><br />
        </div>
        <div class="col-md-6">
            <label>Bairro: </label>
            <asp:TextBox ID="txtBairro" class="form-control" runat="server"></asp:TextBox><br />
        </div>
        <div class="col-md-6">
            <label>Cidade: </label>
            <asp:TextBox ID="txtCidade" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label>Estado: </label>
                        <asp:TextBox ID="txtEstado" class="form-control" runat="server"></asp:TextBox><br />
        </div>
        <div class="col-md-12">
            <asp:Button ID="btn" cssclass="btn btn-primary" runat="server" Text="Cadastrar" OnClick="btn_Click" />
            <br/><br/>
        </div>
        <div class="col-md-12">
            <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
            <br />
            <br />
        </div>
    
    <div class="container container-extended">
        <asp:GridView ID="gdvPes" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:BoundField DataField="pes_nome" HeaderText="Nome" />
                <asp:BoundField DataField="pes_cpf" HeaderText="CPF" />
                <asp:BoundField DataField="pes_rg" HeaderText="RG" />
                <asp:BoundField DataField="end_rua" HeaderText="Rua" />
                <asp:BoundField DataField="end_numero" HeaderText="Nº" />
                <asp:BoundField DataField="end_bairro" HeaderText="Bairro" />
                <asp:BoundField DataField="end_cidade" HeaderText="Cidade" />
                <asp:BoundField DataField="end_estado" HeaderText="UF" />
                <asp:BoundField DataField="end_cep" HeaderText="CEP" />
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
</asp:Content>

