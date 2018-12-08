using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Sessao_PaginaIncial : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Session["usuario"] = txtLogin.Text;
        Response.Redirect("Pagina1.aspx");
    }
}