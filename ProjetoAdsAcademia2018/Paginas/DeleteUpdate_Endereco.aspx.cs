using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Paginas_DeleteUpdate_Endereco : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarDDL();
        }
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Endereco end = new Endereco();
        
        end.End_numero = txtNumero.Text;
        end.End_rua = txtRua.Text;
        end.End_bairro = txtBairro.Text;
        end.End_cidade = txtCidade.Text;
        end.End_estado = txtEstado.Text;
        end.End_cep = txtCEP.Text;
        end.End_codigo = Convert.ToInt32(ddlPessoa.SelectedValue.ToString());

        Pessoa p = new Pessoa();
        //p.Pes_codigo = Convert.ToInt32(ddlPessoa.SelectedValue);
        p.Pes_codigo = Convert.ToInt32(lblCodigoPessoa.Text);
        end.Pes_codigo = p;

        switch (EnderecoDB.Update(end))
        {
            case 0:
                lblMSG.Text = "<div class='alert alert-success'> >>>OK<<< </div>";
                break;

            case -2:
                lblMSG.Text = "<div class='alert alert-danger'> >>>ERRO<<< </div>";
                break;
        }
        txtNumero.Text = "";
        txtRua.Text = "";
        txtBairro.Text = "";
        txtCidade.Text = "";
        txtEstado.Text = "";
        txtCEP.Text = "";
        CarregarDDL();
    }

    protected void ddlPessoa_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlPessoa.SelectedItem.ToString() != "Selecione um valor...")
        {
            lblMSG.Text = "";
            lblpessoa.Text = "";
            DataSet ds = EnderecoDB.SelectID(Convert.ToInt32(ddlPessoa.SelectedValue));
            int qtd = ds.Tables[0].Rows.Count;

            if (qtd == 1)
            {
                txtRua.Text = ds.Tables[0].Rows[0]["end_rua"].ToString();
                txtNumero.Text = ds.Tables[0].Rows[0]["end_numero"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["end_bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["end_cidade"].ToString();
                txtEstado.Text = ds.Tables[0].Rows[0]["end_estado"].ToString();
                txtCEP.Text = ds.Tables[0].Rows[0]["end_cep"].ToString();
                lblCodigoPessoa.Text = ds.Tables[0].Rows[0]["pes_codigo"].ToString();

            }
            else
            {
                lblMSG.Text = "<div class='alert alert-danger'>   Procure o adminstrador do sistema!   </div>";
            }
        }
        else
        {
            lblMSG.Text = "<div class='alert alert-danger'>   Selecione um nome   </div>";
            lblpessoa.Text = "<small class='text-danger'> Selecione um nome</small>";
        }
    }

    protected void btnDeletar_Click(object sender, EventArgs e)
    {
        Endereco end = new Endereco();

        end.End_numero = txtNumero.Text;
        end.End_rua = txtRua.Text;
        end.End_bairro = txtBairro.Text;
        end.End_cidade = txtCidade.Text;
        end.End_estado = txtEstado.Text;
        end.End_cep = txtCEP.Text;

        Pessoa p = new Pessoa();
        p.Pes_codigo = Convert.ToInt32(ddlPessoa.SelectedValue);
        end.Pes_codigo = p;

        //Exemplo criptografia
        //email = txt;
        //cript = txtsenhar
        //Paginas_TrocarSenha = código crip

        //switch(UsuarioDB.SelectID(email, senha))

        switch (EnderecoDB.Delete(end.End_codigo))
        {
            case 0:
                lblMSG.Text = "<div class='alert alert-success'> >>>OK<<< </div>";
                break;

            case -2:
                lblMSG.Text = "<div class='alert alert-danger'> >>>ERRO<<< </div>";
                break;
        }
        txtNumero.Text = "";
        txtRua.Text = "";
        txtBairro.Text = "";
        txtCidade.Text = "";
        txtEstado.Text = "";
        txtCEP.Text = "";
        CarregarDDL();
    }

    public void CarregarDDL()
    {
        DataSet ds = EnderecoDB.SelectAll();
        ddlPessoa.DataSource = ds;
        // texto
        ddlPessoa.DataTextField = "pes_nome";
        //valor
        ddlPessoa.DataValueField = "end_codigo";
        ddlPessoa.DataBind();

        ddlPessoa.Items.Insert(0, "Selecione um valor...");
    }
}