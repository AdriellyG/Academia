using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Academia
/// </summary>
public class Academia
{
    private int aca_codigo;
    private string aca_nomeFantasia;
    private string aca_razaoSocial;
    private string aca_cnpj;

    public int Aca_codigo { get => aca_codigo; set => aca_codigo = value; }
    public string Aca_nomeFantasia { get => aca_nomeFantasia; set => aca_nomeFantasia = value; }
    public string Aca_razaoSocial { get => aca_razaoSocial; set => aca_razaoSocial = value; }
    public string Aca_cnpj { get => aca_cnpj; set => aca_cnpj = value; }
}