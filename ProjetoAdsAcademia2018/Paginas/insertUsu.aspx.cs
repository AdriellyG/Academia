using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.IO;
using System.Security.Cryptography;

public partial class Paginas_insertUsu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarGrid();

            //Carregar um DropDownList com o Banco de Dados          
            DataSet ds = PessoaDB.SelectAll();
            ddlUsuario.DataSource = ds;
            ddlUsuario.DataTextField = "pes_nome"; // Nome da coluna do Banco de dados          
            ddlUsuario.DataValueField = "pes_codigo"; // ID da coluna do Banco          
            ddlUsuario.DataBind();
            ddlUsuario.Items.Insert(0, "Selecione");
        }
        
        if (!IsPostBack)
        {
            CarregarGrid();
            DataSet ds = PerfilDB.SelectAll();
            ddlPerfil.DataSource = ds;
            ddlPerfil.DataTextField = "per_descricaoPerfil"; // Nome da coluna do Banco de dados          
            ddlPerfil.DataValueField = "per_codigo"; // ID da coluna do Banco          
            ddlPerfil.DataBind();
            ddlPerfil.Items.Insert(0, "Selecione");

        }

        lbl.Text = "<div class='alert alert-info'> Cadastro </div>";
    }

    protected void btnCadastro_Click(object sender, EventArgs e)
    {
        Usuario usu = new Usuario();
        usu.Usu_email = txtLogin.Text;
        usu.Usu_dataCadastro = Convert.ToDateTime(txtData.Text);




        UnicodeEncoding UE = new UnicodeEncoding();
        byte[] HashValue, MessageBytes = UE.GetBytes(txtSenha.Text);
        SHA512Managed SHhash = new SHA512Managed();
        string strHex = "";

        HashValue = SHhash.ComputeHash(MessageBytes);
        foreach (byte b in HashValue)
        {
            strHex += String.Format("{0:x2}", b);
        }
        



        usu.Usu_senha = strHex;

        Pessoa pes = new Pessoa();
        pes.Pes_codigo = Convert.ToInt32(ddlUsuario.SelectedValue);
        usu.Pes_codigo = pes;

        Perfil per = new Perfil();
        per.Per_codigo = Convert.ToInt32(ddlPerfil.SelectedValue);
        usu.Per_codigo = per;

        switch (UsuarioDB.Insert(usu))
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
        DataSet ds = UsuarioDB.SelectAll();
        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            gdv.DataSource = ds.Tables[0].DefaultView;
            gdv.DataBind();
            gdv.Visible = true;
            lblGrid.Text = "Foram encontrados " + qtd + " de registros";
        }
        else
        {
            gdv.Visible = false;
            lblGrid.Text = "Não foram encontrado registros...";
        }
    }
}