using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["USUARIO"] != null) {
            lblUsuarioNome.Text = Session["nome"].ToString();
            btnSair.Visible = true;
        }
    }

    protected void btnSair_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Session.Clear();
        Response.Redirect("Default.aspx");
    }
}
