<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="insertCliente.aspx.cs" Inherits="Paginas_Cliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   
        
            <h1 class="jumbotron">Cadastro de Clientes</h1>
    <div class="container">
            <br />
            <br />
            <div class="col-md-6">
                <label>Nome:</label>
                <asp:DropDownList ID="ddlPessoa" cssclass="form-control" runat="server"></asp:DropDownList>
            </div>
            <br />
            <div class="col-md-6">
                <label>Ativo:</label>
                    
                <asp:RadioButtonList ID="rblStatus" runat="server" CssClass="radioButtonList form-control" Width="200px" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="True">Sim</asp:ListItem>
                    <asp:ListItem Value="False" >Não</asp:ListItem>
                </asp:RadioButtonList>
                <br /><br />
            </div>
            <div class="col-md-8">
                <asp:Label ID="lblMSG" runat ="server"></asp:Label>
            </div>
            <div class="col-md-12">
                
                <asp:Button ID="btnCadastrar" CssClass="btn btn-primary" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" />
                <br /><br />
            </div>
        <div class="col-md-12">
                <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="pes_nome" HeaderText="Pessoa" />
                        <asp:BoundField DataField="cli_ativo" HeaderText="Ativo" />
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
</asp:Content>

