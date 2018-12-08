using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using System.Security.Cryptography;

public partial class Paginas_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEntrar_Click(object sender, EventArgs e)
    {
        string cpr = "";
        if (txtUsuario.Text != "" && txtSenha.Text != "")
        {
            cpr = Funcao.Criptografar(txtSenha.Text);

            Pessoa pes = UsuarioDB.ValidaAcesso(txtUsuario.Text, cpr);
            if (pes != null)
            {
                Session["USUARIO"] = pes;
                Session["NOME"] = pes.Pes_nome;
                Response.Redirect("CadastroAcademia.aspx", false);
            }
            else
                Response.Write("<script>alert('login e senha inválido')</script>");
        }
        else
            Response.Write("<script>alert('preencha login e senha')</script>");

    }

}

