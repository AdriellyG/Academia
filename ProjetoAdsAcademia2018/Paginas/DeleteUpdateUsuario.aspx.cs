using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Paginas_DeleteUpdateUsuario : System.Web.UI.Page
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
        Usuario usu = new Usuario();

        usu.Usu_dataCadastro = Convert.ToDateTime(txtData.Text);
        usu.Usu_email = txtLogin.Text;
        usu.Usu_senha = txtSenha.Text;
        usu.Usu_codigo = Convert.ToInt32(ddlUsuario.SelectedValue.ToString());
        
        switch (UsuarioDB.Update(usu))
        {
            case 0:
                lblMSG.Text = "<div class='alert alert-success'> >>>OK<<< </div>";
                break;

            case -2:
                lblMSG.Text = "<div class='alert alert-danger'> >>>ERRO<<< </div>";
                break;
        }
        txtLogin.Text = "";
        txtSenha.Text = "";
        txtData.Text = "";
        CarregarDDL();
    }

    protected void ddlPessoa_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlUsuario.SelectedItem.ToString() != "Selecione um valor...")
        {
            lblMSG.Text = "";
            DataSet ds = UsuarioDB.SelectID(Convert.ToInt32(ddlUsuario.SelectedValue));
            int qtd = ds.Tables[0].Rows.Count;

            if (qtd == 1)
            {
                txtData.Text = ds.Tables[0].Rows[0]["usu_datacadastro"].ToString();
                txtLogin.Text = ds.Tables[0].Rows[0]["usu_email"].ToString();
                txtSenha.Text = ds.Tables[0].Rows[0]["usu_senha"].ToString();

            }
            else
            {
                lblMSG.Text = "<div class='alert alert-danger'>   Procure o adminstrador do sistema!   </div>";
            }
        }
        else
        {
            lblMSG.Text = "<div class='alert alert-danger'>   Selecione um nome   </div>";
        }
    }

    protected void btnDeletar_Click(object sender, EventArgs e)
    {
        Usuario usu = new Usuario();

        usu.Usu_dataCadastro = Convert.ToDateTime(txtData.Text);
        usu.Usu_email = txtLogin.Text;
        usu.Usu_senha = txtSenha.Text;

        switch (UsuarioDB.Delete(usu.Usu_codigo))
        {
            case 0:
                lblMSG.Text = "<div class='alert alert-success'> >>>OK<<< </div>";
                break;

            case -2:
                lblMSG.Text = "<div class='alert alert-danger'> >>>ERRO<<< </div>";
                break;
        }
        txtLogin.Text = "";
        txtSenha.Text = "";
        txtData.Text = "";
        
        CarregarDDL();
    }

    public void CarregarDDL()
    {
        DataSet ds = UsuarioDB.SelectAll();
        ddlUsuario.DataSource = ds;
        
        ddlUsuario.DataTextField = "usu_datacadastro";
        ddlUsuario.DataValueField = "usu_login";
        ddlUsuario.DataValueField = "usu_senha";

        ddlUsuario.DataBind();

        ddlUsuario.Items.Insert(0, "Selecione um valor...");
    }
}