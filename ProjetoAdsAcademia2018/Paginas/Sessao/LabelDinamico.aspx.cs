using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Paginas_LabelDinamico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarLbl();
        CarregarLit();

        if(Session["usuario"] == null || Session["usuario"] == ""){
            lblNome.Text = "Usuário não encontrado!";
        }
        else{
            lblNome.Text = Session["usuario"].ToString();
        }
        
    }
    public void CarregarLbl()
    {
        DataSet ds = AcademiaDB.SelectAll();
        lbl.Text = "";

        foreach(DataRow dr in ds.Tables[0].Rows)
        {
            lbl.Text += "<div class='col-md-3'>";
            lbl.Text += "<div class='alert alert-success'>";
            lbl.Text += "<h3>";
            lbl.Text += dr["aca_nomefantasia"];
            lbl.Text += "</h3>";
            lbl.Text += "</div>";
            lbl.Text += "<div class='thumbnail'>";
            lbl.Text += "<p>" + dr["aca_razaosocial"] + "</p>";
            lbl.Text += "<p>" + dr["aca_cnpj"] + "</p>";
            lbl.Text += "</div>";
            lbl.Text += "</div>";
        }
    }

    public void CarregarLit()
    {
        DataSet ds = AcademiaDB.SelectAll();
        tabela.Text = "";
        tabela.Text += "<table class='table table-responsive'>";
        tabela.Text += "<tr class='alert alert-danger'>";
        tabela.Text += "<td>Nome</td>";
        tabela.Text += "<td>Razão Social</td>";
        tabela.Text += "<td>CNPJ</td>";
        tabela.Text += "</tr>";
        

        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            tabela.Text += "<tr>";

            tabela.Text += "<td>" + dr["aca_nomefantasia"] + "</td>";
            tabela.Text += "<td>" + dr["aca_razaosocial"] + "</td>";
            tabela.Text += "<td>" + dr["aca_cnpj"] + "</td";

            tabela.Text += "</tr>";
        }
        tabela.Text += "</table>";
    }
}
