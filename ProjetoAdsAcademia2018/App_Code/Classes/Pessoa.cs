using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Pessoa
/// </summary>
public class Pessoa
{
    private int pes_codigo;
    private string pes_nome;
    private string pes_cpf;
    private string pes_rg;
    public Usuario Usuario { get; set; }
    public int Pes_codigo { get => pes_codigo; set => pes_codigo = value; }
    public string Pes_nome { get => pes_nome; set => pes_nome = value; }
    public string Pes_cpf { get => pes_cpf; set => pes_cpf = value; }
    public string Pes_rg { get => pes_rg; set => pes_rg = value; }
}