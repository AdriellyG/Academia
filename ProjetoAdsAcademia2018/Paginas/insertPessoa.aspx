<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="insertPessoa.aspx.cs" Inherits="Paginas_insertPessoa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1 class="jumbotron">Cadastro Pessoa</h1>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <label>Nome:</label>
                <asp:textbox id="txtNome" runat="server" cssclass="form-control"></asp:textbox>
            </div>
            <div class="col-md-6">
                <label>CPF:</label>
                <asp:textbox id="txtCPF" runat="server" cssclass="form-control"></asp:textbox>
            </div>
            <div class="col-md-6">
                <label>RG:</label>
                <asp:textbox id="txtRG" runat="server" cssclass="form-control"></asp:textbox>
            </div>
            <div class="col-md-12">
                <br/><br/>
                <asp:button id="btn" runat="server" text="Salvar" cssclass="btn btn-primary ml-2" onclick="btn_Click" />
            </div>

            <div class="col-md-12">
                <br />
                <br />
                <asp:label id="lbl" runat="server"></asp:label>
            </div>

        </div>
    </div>
    <br />
    <br />
    <div class="container">
        <asp:gridview id="gdvPes" runat="server" backcolor="White" bordercolor="#999999" borderstyle="Solid" borderwidth="1px" cellpadding="3" forecolor="Black" gridlines="Vertical" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="pes_nome" HeaderText="Nome completo" />
                        <asp:BoundField DataField="pes_cpf" HeaderText="CPF" />
                        <asp:BoundField DataField="pes_rg" HeaderText="RG" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:gridview>
        <br />
        <asp:label id="lblGrid" runat="server" text="---"></asp:label>
    </div>
    <div class="col-md-12">
    </div>
</asp:Content>

