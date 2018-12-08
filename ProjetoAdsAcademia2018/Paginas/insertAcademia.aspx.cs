using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Paginas_insertAcademia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarGrid();
        }
        lbl.Text = "<div class='alert alert-info'> Cadastro </div>";
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Academia acad = new Academia();
        acad.Aca_razaoSocial = txtRazao.Text;
        acad.Aca_nomeFantasia = txtNome.Text;
        acad.Aca_cnpj = txtCNPJ.Text;

        switch (AcademiaDB.Insert(acad))
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
        DataSet ds = AcademiaDB.SelectAll();
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