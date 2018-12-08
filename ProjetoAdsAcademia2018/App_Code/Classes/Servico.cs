using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Servico
/// </summary>
public class Servico
{
    private int ser_codigo;
    private string ser_descricaoServico;


    public int Ser_codigo { get => ser_codigo; set => ser_codigo = value; }
    public string Ser_descricaoServico { get => ser_descricaoServico; set => ser_descricaoServico = value; }
}