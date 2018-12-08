using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Cliente
/// </summary>
public class Cliente
{
    private int cli_codigo;
    private bool cli_ativo;

    //FK
    private Pessoa pes_codigo;

    public int Cli_codigo { get => cli_codigo; set => cli_codigo = value; }
    public bool Cli_ativo { get => cli_ativo; set => cli_ativo = value; }
    public global::Pessoa Pes_codigo { get => pes_codigo; set => pes_codigo = value; }
}