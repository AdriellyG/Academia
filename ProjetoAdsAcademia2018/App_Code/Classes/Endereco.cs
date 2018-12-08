using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Endereco
/// </summary>
public class Endereco
{
    private int end_codigo;
    private string end_rua;
    private string end_numero;
    private string end_bairro;
    private string end_cidade;
    private string end_estado;
    private string end_cep;

    //FK
    private Pessoa pes_codigo;

    public int End_codigo { get => end_codigo; set => end_codigo = value; }
    public string End_rua { get => end_rua; set => end_rua = value; }
    public string End_numero { get => end_numero; set => end_numero = value; }
    public string End_bairro { get => end_bairro; set => end_bairro = value; }
    public string End_cidade { get => end_cidade; set => end_cidade = value; }
    public string End_estado { get => end_estado; set => end_estado = value; }
    public string End_cep { get => end_cep; set => end_cep = value; }
    public global::Pessoa Pes_codigo { get => pes_codigo; set => pes_codigo = value; }
}