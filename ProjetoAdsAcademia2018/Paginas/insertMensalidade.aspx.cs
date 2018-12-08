using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Paginas_insertMensalidade : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarGrid();

            DataSet ds = ServicoDB.SelectAll();
            ddlServico.DataSource = ds;
            ddlServico.DataTextField = "ser_descricaoservico"; // Nome da coluna do Banco de dados          
            ddlServico.DataValueField = "ser_codigo"; // ID da coluna do Banco          
            ddlServico.DataBind();
            ddlServico.Items.Insert(0, "Selecione");
        }

        lbl.Text = "<div class='alert alert-info'> Cadastro </div>";
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Mensalidade men = new Mensalidade();
        men.Men_valor = Convert.ToDouble(txtMensalidade.Text);
        men.Men_dataPagamento = txtVencimento.Text;
        men.Men_status = Convert.ToBoolean(rblStatus.SelectedValue);


        Servico ser = new Servico();
        ser.Ser_codigo = Convert.ToInt32(ddlServico.SelectedValue);
        men.Ser_codigo = ser;

        switch (MensalidadeDB.Insert(men))
        {
            case 0:
                lbl.Text = "<div class='alert alert-success'> >>>OK<<< </div>";
                break;

            case -2:
                lbl.Text = "<div class='alert alert-danger'> >>>ERRO<<< </div>";
                break;
        }
        CarregarGrid();
    }

    public void CarregarGrid()
    {         //DataSet ds = new DataSet();         
        DataSet ds = MensalidadeDB.SelectAll();
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



    protected void rblStatus_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}