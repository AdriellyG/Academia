<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="insertMensalidade.aspx.cs" Inherits="Paginas_insertMensalidade" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style>
        :root {
            --widthCelula: 25%;
        }

        ul.radioButtonList {
            list-style: none;
            margin: 0;
            padding: 0;
        }

            ul.radioButtonList.horizontal li {
                display: inline;
            }

        /*tbody{
            overflow:auto;
            height:500px;
            float:left;
        }*/
    </style>
    <h1 class="jumbotron">Cadastro de Mensalidade</h1>
    <div class="container">
        <br />
        <div class="row">
            <div class="col-md-6">
                <label>Serviço: </label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlServico" cssclass="form-control" runat="server"></asp:DropDownList>
                <br />
                <br />
            </div>
            <div class="col-md-6">
                <label>Mensalidade: </label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtMensalidade" cssclass="form-control" runat="server"></asp:TextBox>
                <br />
                <br />
            </div>
            <div class="col-md-6">
                <label>Vencimento: </label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtVencimento" cssclass="form-control" runat="server" type="Date"></asp:TextBox>
                <br />
                <br />
            </div>
            <div class="col-md-6">
                <label>Ativo: </label>
                <asp:RadioButtonList ID="rblStatus" runat="server" CssClass="radioButtonList" Width="200px" RepeatDirection="Horizontal" OnSelectedIndexChanged="rblStatus_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Value="True">Sim</asp:ListItem>
                    <asp:ListItem Value="False" >Não</asp:ListItem>
                </asp:RadioButtonList>
                <br/><br/>
            </div>
            <div class="col-md-12">
                <asp:Button ID="btn" CssClass="btn btn-primary" runat="server" Text="CADASTRAR" OnClick="btn_Click" />
                <br /><br />
            </div>
            <div class="col-md-12">
                <asp:Label ID="lbl" runat="server"></asp:Label>
            </div>
            <br />
                <br />
            <div class="col-md-12">
                <asp:GridView ID="gdv" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="ser_descricaoServico" HeaderText="Descrição" />
                        <asp:BoundField DataField="men_valor" HeaderText="Valor" />
                        <asp:BoundField DataField="men_datapamento" HeaderText="Data" />
                        <asp:BoundField DataField="men_status" HeaderText="Status" />
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

