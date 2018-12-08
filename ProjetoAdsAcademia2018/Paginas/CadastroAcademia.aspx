<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="CadastroAcademia.aspx.cs" Inherits="Paginas_CadastroAcademia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <h1 class="jumbotron">Cadastro Academia</h1>
    <div class="container">
        <br />
        <div class="row">
            <div class="col-md-6">
                <label>Nome: </label>
                <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
                <br /><br />
            </div>

            <div class="col-md-6">
                <label>Razão Social: </label>
                <asp:TextBox ID="txtRazao" CssClass="form-control" runat="server"></asp:TextBox>
                <br /><br />
            </div>
            <div class="col-md-6">
                <label>CNPJ: </label>
                <asp:TextBox ID="txtCNPJ" CssClass="form-control" runat="server"></asp:TextBox>
                <br /><br />
            </div>
            <div class="col-md-12">
                <asp:Button ID="btn" CssClass="btn btn-primary" runat="server" Text="CADASTRAR" OnClick="btn_Click" />
                <br /><br />
            </div>
            <div class="col-md-12">
                <asp:Label ID="lbl" runat="server"></asp:Label>
                <br /><br />
            </div>
            <div class="col-md-12">
                <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical"   style="padding:20px;">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="aca_nomefantasia" HeaderText="Nome Fantasia" />
                        <asp:BoundField DataField="aca_razaosocial" HeaderText="Razão Social" />
                        <asp:BoundField DataField="aca_cnpj" HeaderText="CNPJ" />
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
                <br /><br />
            </div>
            <div class="col-md-12">
                <asp:Label ID="lblGrid" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>

