using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Mensalidade
/// </summary>
public class Mensalidade
{
    private int men_codigo;
    private double men_valor;
    private string men_dataPagamento;
    private bool men_status;

    //Fk
    private Servico ser_codigo;

    public int Men_codigo { get => men_codigo; set => men_codigo = value; }
    public double Men_valor { get => Men_valor1; set => Men_valor1 = value; }
    public string Men_dataPagamento { get => men_dataPagamento; set => men_dataPagamento = value; }
    public bool Men_status { get => men_status; set => men_status = value; }
    public global::Servico Ser_codigo { get => ser_codigo; set => ser_codigo = value; }
    public double Men_valor1 { get => men_valor; set => men_valor = value; }
}