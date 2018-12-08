using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Sessao_Pagina1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usuario"] == null)
        {
            Response.Redirect("PaginaInicial.aspx");
        }
        else
        {
            lblNome.Text = Session["usuario"].ToString(); 
        }
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaginaFinal.aspx");
    }
}