<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="insertServico.aspx.cs" Inherits="Paginas_insertServico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1 class="jumbotron">Cadastro de Serviço</h1>
    <div class="container">
        <br />
        <div class="row">
            <div class="col-md-6">
                <label>Descrição do Serviço:</label>
                <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control"></asp:TextBox>

            </div>

            <div class="col-md-8 mt-5">
                <asp:Button ID="btn" runat="server" Text="Salvar" CssClass="btn btn-primary" OnClick="btn_Click" />
            </div>
            <div class="col-md-12">
                <br />
                <br />
                <asp:Label ID="lbl" runat="server"></asp:Label>
            </div>
            <br />
            <br />
            <div class="col-md-12">

                <br />
                <br />
                <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="ser_descricaoServico" HeaderText="Serviço" />
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

            <div class="col-md-12">
                <br />
                <br />
                <asp:Label ID="lblGrid" runat="server" Text="---"></asp:Label>
            </div>

        </div>
    </div>
</asp:Content>

