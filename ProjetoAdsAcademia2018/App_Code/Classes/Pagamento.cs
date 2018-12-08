using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Pagamento
/// </summary>
public class Pagamento
{
    private int pag_codigo;
    private float pag_valor;
    private string pag_dataPagamento;

    //Fk
    private Cliente cli_codigo;

    public int Pag_codigo { get => pag_codigo; set => pag_codigo = value; }
    public float Pag_valor { get => pag_valor; set => pag_valor = value; }
    public string Pag_dataPagamento { get => pag_dataPagamento; set => pag_dataPagamento = value; }
    public global::Cliente Cli_codigo { get => cli_codigo; set => cli_codigo = value; }
}