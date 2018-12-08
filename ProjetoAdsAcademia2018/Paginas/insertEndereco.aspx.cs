using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Paginas_insertEndereco : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarGrid();

            //Carregar um DropDownList com o Banco de Dados          
            DataSet ds = PessoaDB.SelectAll();
            ddl.DataSource = ds;
            ddl.DataTextField = "pes_nome"; // Nome da coluna do Banco de dados          
            ddl.DataValueField = "pes_codigo"; // ID da coluna do Banco          
            ddl.DataBind();
            ddl.Items.Insert(0, "Selecione");
        }

        lbl.Text = "<div class='alert alert-info'> Cadastro </div>";

    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Endereco end = new Endereco();
        end.End_cep = txtCEP.Text;
        end.End_estado = txtEstado.Text;
        end.End_cidade = txtCidade.Text;
        end.End_bairro = txtBairro.Text;
        end.End_rua = txtLogradouro.Text;
        end.End_numero = txtNumero.Text;

        Pessoa p = new Pessoa();
        p.Pes_codigo = Convert.ToInt32(ddl.SelectedValue);

        end.Pes_codigo = p;

        switch (EnderecoDB.Insert(end))
        {
            case 0:
                lbl.Text = "<div class='alert alert-success'> >>>OK<<< </div>";
                break;

            case -2:
                lbl.Text = "<div class='alert alert-danger'> >>>ERRO<<< </div>";
                break;
        }
        txtNumero.Text = "";
        txtLogradouro.Text = "";
        txtBairro.Text = "";
        txtCidade.Text = "";
        txtEstado.Text = "";
        txtCEP.Text = "";
        CarregarGrid();
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {

        using (var ws = new WSCorreios.AtendeClienteClient())
        {
            try
            {
                var resultado = ws.consultaCEP(txtCEP.Text);
                txtLogradouro.Text = resultado.end;
                txtCidade.Text = resultado.cidade;
                txtBairro.Text = resultado.bairro;
                txtEstado.Text = resultado.uf;
            }
            catch (Exception ex)
            {
                lbl.Text = "<div class='alert alert-danger'> >>>CEP não encontrado!<<< </div>"; ;
            }
        }
    }

    public void CarregarGrid()
    {         //DataSet ds = new DataSet();         
        DataSet ds = EnderecoDB.SelectAll();
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            gdvPes.DataSource = ds.Tables[0].DefaultView;
            gdvPes.DataBind();
            gdvPes.Visible = true;
            lblGrid.Text = "Foram encontrados " + qtd + " de registros";
        }
        else
        {
            gdvPes.Visible = false;
            lblGrid.Text = "Não foram encontrado registros...";
        }
    }
}