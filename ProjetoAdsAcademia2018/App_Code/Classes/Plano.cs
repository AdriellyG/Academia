using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Plano
/// </summary>
public class Plano
{
    private int pla_codigo;
    private string pla_dataVencimento;

    //Fk
    private Cliente cli_codigo;
    private Servico ser_codigo;

    public int Pla_codigo { get => pla_codigo; set => pla_codigo = value; }
    public string Pla_dataVencimento { get => pla_dataVencimento; set => pla_dataVencimento = value; }
    public global::Cliente Cli_codigo { get => cli_codigo; set => cli_codigo = value; }
    public global::Servico Ser_codigo { get => ser_codigo; set => ser_codigo = value; }
}
