using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
    
public partial class Paginas_Cliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarGrid();

            DataSet ds = UsuarioDB.SelectAll();
            ddlPessoa.DataSource = ds;
            ddlPessoa.DataTextField = "pes_nome"; // Nome da coluna do Banco de dados          
            ddlPessoa.DataValueField = "pes_codigo";
            ddlPessoa.DataBind();
            ddlPessoa.Items.Insert(0, "Selecione");
        }

        
    }
    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        Cliente cli = new Cliente();

        cli.Cli_ativo = Convert.ToBoolean(rblStatus.SelectedValue);
        
        Pessoa p = new Pessoa();
        p.Pes_codigo = Convert.ToInt32(ddlPessoa.SelectedValue);
        cli.Pes_codigo = p;

        switch (ClienteDB.Insert(cli))
        {
            case 0:
                lblMSG.Text = "<div class='alert alert-success'> >>>OK<<< </div>";
                break;

            case -2:
                lblMSG.Text = "<div class='alert alert-danger'> >>>ERRO<<< </div>";
                break;
        }
        
        CarregarGrid();
    }

    public void CarregarGrid()
    {
        DataSet ds = ClienteDB.SelectAll();
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            gdv.DataSource = ds.Tables[0].DefaultView;
            gdv.DataBind();
            gdv.Visible = true;
            lblGrid.Text = "Foram encontrados " + qtd + " registros";
        }
        else
        {
            gdv.Visible = false;
            lblGrid.Text = "Não foram encontrado registros.";
        }
    }
}